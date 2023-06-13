using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services.Database;
using VeterinarskaStanica.Services.ProductStateMachine;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace VeterinarskaStanica.Services
{
	public class ProizvodiService : BaseCRUDService<Model.Proizvodi, Database.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>, IProizvodiService
	{
		public BaseState BaseState { get; set; }
		public ProizvodiService(VeterinarskaStanicaContext context, IMapper mapper, BaseState baseState)
			: base(context, mapper)
		{
			BaseState = baseState;
		}

		public override Model.Proizvodi Insert(ProizvodiInsertRequest insert)
		{
			//return base.Insert(insert);
			var state = BaseState.CreateState("initial");
			return state.Insert(insert);
		}

		public override Model.Proizvodi Update(int id, ProizvodiUpdateRequest update)
		{
			var product = Context.Proizvodis.Find(id);
			var state = BaseState.CreateState(product.StateMachine);
			state.Context = Context;
			state.CurrentEntity = product;
			state.Update(update);
			return GetById(id);
		}

		public Model.Proizvodi Activate(int id)
		{
			var product = Context.Proizvodis.Find(id);
			var state = BaseState.CreateState(product.StateMachine);
			state.Context = Context;
			state.CurrentEntity = product;
			state.Activate();
			return GetById(id);
		}

		public List<string> AllowedActions(int id)
		{
			var product = GetById(id);
			var state = BaseState.CreateState(product.StateMachine);
			return state.AllowedActions();
		}

		public override IQueryable<Database.Proizvodi> AddFilter(IQueryable<Database.Proizvodi> query, ProizvodiSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (!string.IsNullOrWhiteSpace(search?.Naziv))
			{
				filteredQuery = filteredQuery.Where(x => x.Naziv.Contains(search.Naziv)
				|| x.Naziv.Contains(search.Naziv));
			}
			if (!string.IsNullOrWhiteSpace(search?.Sifra))
			{
				filteredQuery = filteredQuery.Where(x => x.Sifra.Contains(search.Sifra)
				|| x.Sifra.Contains(search.Sifra));
			}
			return filteredQuery;
		}
		static object isLocked = new object();
		static MLContext mlContext = null;
		static ITransformer model = null;
		public List<Model.Proizvodi> Recommend(int id)
		{
			lock (isLocked)
			{
				if (mlContext == null)
				{
					mlContext = new MLContext();

					var data = new List<ProductEntry>();

					var traindata = mlContext.Data.LoadFromEnumerable(data);

					//STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
					//        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer.
					MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
					options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
					options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
					options.LabelColumnName = "Label";
					options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
					options.Alpha = 0.01;
					options.Lambda = 0.025;
					// For better results use the following parameters
					options.NumberOfIterations = 100;
					options.C = 0.00001;

					var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);
					model = est.Fit(traindata);
				}
		}
			

			var allItems = Context.Proizvodis.Where(x => x.ProizvodId != id);

			var predictionResult = new List<Tuple<Database.Proizvodi, float>>();
			foreach(var item in allItems)
			{
				var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry,Copurchase_prediction>(model);
				var prediction = predictionEngine.Predict(new ProductEntry()
				{
					ProductID = (uint)id,
					CoPurchaseProductID = (uint)item.ProizvodId
				});
				predictionResult.Add(new Tuple<Database.Proizvodi, float>(item, prediction.Score));
			}
			var finalResult = predictionResult.OrderByDescending(x => x.Item2)
				.Select(x=>x.Item1).Take(3).ToList();

			return Mapper.Map<List<Model.Proizvodi>>(finalResult);
		}


		public class Copurchase_prediction
		{
			public float Score { get; set; }
		}

		public class ProductEntry
		{
			[KeyType(count: 10)]
			public uint ProductID { get; set; }

			[KeyType(count: 10)]
			public uint CoPurchaseProductID { get; set; }

			public float Label { get; set; }
		}
	}
}
