using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ZaposleniciController : BaseCRUDController<Model.Zaposlenici, ZaposleniciSearchObject, ZaposleniciInsertRequest, ZaposleniciUpdateRequest>
	{
		public IZaposleniciService ZaposleniciService { get; set; }
		public ZaposleniciController(IZaposleniciService zaposleniciService)
			: base(zaposleniciService)
		{
			ZaposleniciService = zaposleniciService;
		}
	}
}
