using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;
using VeterinarskaStanica.Services.Database;

namespace VeterinarskaStanica.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProizvodiController : BaseCRUDController<Model.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
	{
		public IProizvodiService ProizvodiService { get; set; }
		public ProizvodiController(IProizvodiService proizvodiService)
			:base(proizvodiService)
		{
			ProizvodiService = proizvodiService;
		}
		[HttpPut("{id}/Activate")]
		public Model.Proizvodi Activate(int id)
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
		public List<Model.Proizvodi> Recommend(int id)
		{
			var result = ProizvodiService.Recommend(id);
			return result;
		}
	}
}
