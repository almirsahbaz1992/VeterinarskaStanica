using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class KorisniciController : BaseCRUDController<Model.Korisnici, KorisniciSearchObject, KorisniciInsertRequest, KorisniciUpdateRequest>
	{
		public KorisniciController(IKorisniciService service)
			:base(service)
		{

		}
		//[Authorize("Administrator")]
		public override Korisnici Insert([FromBody] KorisniciInsertRequest insert)
		{
			return base.Insert(insert);
		}
		//[Authorize("Administrator")]
		public override Korisnici Update(int id, [FromBody] KorisniciUpdateRequest update)
		{
			return base.Update(id, update);
		}
	}
}
