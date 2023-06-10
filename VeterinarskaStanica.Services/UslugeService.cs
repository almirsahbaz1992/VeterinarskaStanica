//using AutoMapper;
//using Microsoft.ML.Data;
//using Microsoft.ML.Trainers;
//using Microsoft.ML;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using VeterinarskaStanica.Model.Request;
//using VeterinarskaStanica.Model.SearchObjects;
//using VeterinarskaStanica.Services.Database;
//using VeterinarskaStanica.Services.ProductStateMachine;
//using Microsoft.EntityFrameworkCore;

//namespace VeterinarskaStanica.Services
//{
//	public class UslugeService : BaseCRUDService<Model.Usluge, Database.Usluge, UslugeSearchObject, UslugeInsertRequest, UslugeUpdateRequest>, IUslugeService
//	{
//		public BaseState BaseState { get; set; }
//		public UslugeService(VeterinarskaStanicaContext context, IMapper mapper, BaseState baseState)
//			: base(context, mapper)
//		{
//			BaseState = baseState;
//		}

//		public override Model.Usluge Insert(UslugeInsertRequest insert)
//		{
//			//return base.Insert(insert);
//			var state = BaseState.CreateState("initial");
//			return state.Insert(insert);
//		}

//		public override Model.Usluge Update(int id, UslugeUpdateRequest update)
//		{
//			var product = Context.Usluges.Find(id);
//			var state = BaseState.CreateState(product.StateMachine);
//			state.Context = Context;
//			state.CurrentEntity = product;
//			state.Update(update);
//			return GetById(id);
//		}

//		public Model.Usluge Activate(int id)
//		{
//			var product = Context.Usluges.Find(id);
//			var state = BaseState.CreateState(product.StateMachine);
//			state.Context = Context;
//			state.CurrentEntity2 = product;
//			state.Activate();
//			return GetById(id);
//		}

//		public List<string> AllowedActions(int id)
//		{
//			var product = GetById(id);
//			var state = BaseState.CreateState(product.StateMachine);
//			return state.AllowedActions();
//		}

//		public override IQueryable<Database.Usluge> AddFilter(IQueryable<Database.Usluge> query, UslugeSearchObject search = null)
//		{
//			var filteredQuery = base.AddFilter(query, search);
//			if (!string.IsNullOrWhiteSpace(search?.Sifra))
//			{
//				filteredQuery = filteredQuery.Where(x => x.Sifra == search.Sifra);
//			}
//			if (!string.IsNullOrWhiteSpace(search?.Naziv))
//			{
//				filteredQuery = filteredQuery.Where(x => x.Naziv.Contains(search.Naziv));
//			}
//			return filteredQuery;
//		}
//		static object isLocked = new object();
//		static MLContext mlContext = null;
//		static ITransformer model = null;
//		public List<Model.Usluge> Recommend(int id)
//		{
//			lock (isLocked)
//			{
//				if (mlContext == null)
//				{
//					mlContext = new MLContext();

//					var tmpData = Context.Narudzbes.Include("NarudzbaStavkes").ToList();

//					var data = new List<ProductEntry>();

//					foreach (var x in tmpData)
//					{
//						if (x.NarudzbaStavkes.Count > 1)
//						{
//							var distinctItemId = x.NarudzbaStavkes.Select(y => y.ProizvodId).ToList();
//							distinctItemId.ForEach(y =>
//							{
//								var releatedItems = x.NarudzbaStavkes.Where(z => z.ProizvodId != y);
//								foreach (var z in releatedItems)
//								{
//									data.Add(new ProductEntry()
//									{
//										ProductID = (uint)y,
//										CoPurchaseProductID = (uint)z.ProizvodId,
//									});
//								}
//							});
//						}
//					}

//					var traindata = mlContext.Data.LoadFromEnumerable(data);

//					//STEP 3: Your data is already encoded so all you need to do is specify options for MatrxiFactorizationTrainer with a few extra hyperparameters
//					//        LossFunction, Alpa, Lambda and a few others like K and C as shown below and call the trainer.
//					MatrixFactorizationTrainer.Options options = new MatrixFactorizationTrainer.Options();
//					options.MatrixColumnIndexColumnName = nameof(ProductEntry.ProductID);
//					options.MatrixRowIndexColumnName = nameof(ProductEntry.CoPurchaseProductID);
//					options.LabelColumnName = "Label";
//					options.LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass;
//					options.Alpha = 0.01;
//					options.Lambda = 0.025;
//					// For better results use the following parameters
//					options.NumberOfIterations = 100;
//					options.C = 0.00001;

//					var est = mlContext.Recommendation().Trainers.MatrixFactorization(options);
//					model = est.Fit(traindata);
//				}
//			}


//			var allItems = Context.Usluges.Where(x => x.UslugaId != id);

//			var predictionResult = new List<Tuple<Database.Usluge, float>>();
//			foreach (var item in allItems)
//			{
//				var predictionEngine = mlContext.Model.CreatePredictionEngine<ProductEntry, Copurchase_prediction>(model);
//				var prediction = predictionEngine.Predict(new ProductEntry()
//				{
//					ProductID = (uint)id,
//					CoPurchaseProductID = (uint)item.UslugaId
//				});
//				predictionResult.Add(new Tuple<Database.Usluge, float>(item, prediction.Score));
//			}
//			var finalResult = predictionResult.OrderByDescending(x => x.Item2)
//				.Select(x => x.Item1).Take(3).ToList();

//			return Mapper.Map<List<Model.Usluge>>(finalResult);
//		}

//		public class Copurchase_prediction
//		{
//			public float Score { get; set; }
//		}

//		public class ProductEntry
//		{
//			[KeyType(count: 10)]
//			public uint ProductID { get; set; }

//			[KeyType(count: 10)]
//			public uint CoPurchaseProductID { get; set; }

//			public float Label { get; set; }
//		}
//	}
//}
