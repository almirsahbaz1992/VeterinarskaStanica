using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
		[ApiController]
		[Route("[controller]")]
		public class UslugeController : BaseCRUDController<Model.Usluge, UslugeSearchObject, UslugeInsertRequest, UslugeUpdateRequest>
		{
			public IUslugeService ProizvodiService { get; set; }
			public UslugeController(IUslugeService proizvodiService)
				: base(proizvodiService)
			{
				ProizvodiService = proizvodiService;
			}
			[HttpPut("{id}/Activate")]
			public Model.Usluge Activate(int id)
			{
				var result = ProizvodiService.Activate(id);
				return result;
			}
			[HttpPut("{id}/AllowedActions")]
			public List<string> AllowedActions(int id)
			{
				var result = ProizvodiService.AllowedActions(id);
				return result;
			}
			[HttpGet("{id}/Recommend")]
			[AllowAnonymous]
			public List<Model.Usluge> Recommend(int id)
			{
				var result = ProizvodiService.Recommend(id);
				return result;
			}
		}
	}
