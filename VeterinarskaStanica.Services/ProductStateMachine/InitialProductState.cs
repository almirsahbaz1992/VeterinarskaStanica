using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Services.Database;

namespace VeterinarskaStanica.Services.ProductStateMachine
{
	public class InitialProductState : BaseState
	{
		public InitialProductState(IServiceProvider serviceProvider, VeterinarskaStanicaContext context, IMapper mapper)
			: base(serviceProvider, context, mapper)
		{
		}

		public override Model.Proizvodi Insert(ProizvodiInsertRequest request)
		{
			var set = Context.Set<Database.Proizvodi>();

			Database.Proizvodi entity = Mapper.Map<Database.Proizvodi>(request);

			CurrentEntity = entity;
			CurrentEntity.StateMachine = "draft";

			set.Add(entity);

			Context.SaveChanges();

			return Mapper.Map<Model.Proizvodi>(entity);
		}
	}
}
