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
	public class DraftProductState : BaseState
	{
		public DraftProductState(IServiceProvider serviceProvider, VeterinarskaStanicaContext context, IMapper mapper) : base(serviceProvider, context, mapper)
		{
		}

		public override void Update(ProizvodiUpdateRequest request)
		{
			var set = Context.Set<Database.Proizvodi>();

			Mapper.Map(request, CurrentEntity);
			CurrentEntity.StateMachine = "draft";

			Context.SaveChanges();
		}

		public override void Activate()
		{
			CurrentEntity.StateMachine = "active";
			Context.SaveChanges();
		}

		public override List<string> AllowedActions()
		{
			var list = base.AllowedActions();
			list.Add("update");
			list.Add("activate");
			list.Add("hide");
			return list;
		}
	}
}
