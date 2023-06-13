using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RezervacijeController : BaseCRUDController<Model.Rezervacije, RezervacijeSearchObject, RezervacijeInsertRequest, RezervacijeUpdateRequest>

	{
		public IRezervacijeService RezervacijeService { get; set; }
		public RezervacijeController(IRezervacijeService rezervacijeService)
			: base(rezervacijeService)
		{
			RezervacijeService = rezervacijeService;
		}
	}
}
