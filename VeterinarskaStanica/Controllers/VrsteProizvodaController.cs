using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class VrsteProizvodaController : BaseCRUDController<Model.VrstaProizvoda, VrstaProizvodaSearchObject, VrstaProizvodaUpsertRequest, VrstaProizvodaUpsertRequest>
	{
		public VrsteProizvodaController(IVrsteProizvodaService service) : base(service)
		{

		}
	}
}
