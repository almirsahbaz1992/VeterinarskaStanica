using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class VrsteUslugeController : BaseCRUDController<Model.VrsteUsluga, VrsteUslugaSearchObject, VrsteUslugaUpsertRequest, VrsteUslugaUpsertRequest>
	{
		public VrsteUslugeController(IVrsteUslugaService service) : base(service)
		{

		}
	}
}
