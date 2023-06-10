using Microsoft.AspNetCore.Mvc;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class UlogeController : BaseController<Model.Uloge, BaseSearchObject>
	{
		public UlogeController(IService<Model.Uloge, BaseSearchObject> service):base(service)
		{

		}

	}
}
