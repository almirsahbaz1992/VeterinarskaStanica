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
		}
	}
