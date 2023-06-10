using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Services.Database;

namespace VeterinarskaStanica.Services.ProductStateMachine
{
	public class ActiveProductState : BaseState
	{
		public ActiveProductState(IServiceProvider serviceProvider, VeterinarskaStanicaContext context, IMapper mapper) : base(serviceProvider, context, mapper)
		{
		}
	}
}
