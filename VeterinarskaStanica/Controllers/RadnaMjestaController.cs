using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class RadnaMjestaController : BaseCRUDController<Model.RadnaMjesta, RadnaMjestaSearchObject, RadnaMjestaUpsertRequest, RadnaMjestaUpsertRequest>
	{
		public RadnaMjestaController(IRadnaMjestaService service) : base(service)
		{

		}

	}
}
