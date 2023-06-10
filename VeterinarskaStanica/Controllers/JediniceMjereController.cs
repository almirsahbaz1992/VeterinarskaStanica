using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class JediniceMjereController : BaseCRUDController<Model.JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>
	{
		public JediniceMjereController(IJediniceMjereService service):base(service)
		{

		}

	}
}
