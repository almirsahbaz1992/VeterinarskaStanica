using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class NarudzbeController : BaseCRUDController<Model.Narudzbe, NarudzbeSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>
	{
		public INarudzbeService NarudzbeService { get; set; }
		public NarudzbeController(INarudzbeService narudzbeService)
			: base(narudzbeService)
		{
			NarudzbeService = narudzbeService;
		}
	}
}
