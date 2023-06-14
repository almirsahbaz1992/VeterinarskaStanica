using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class NarudzbeStavkeController : BaseCRUDController<Model.NarudzbaStavke, NarudzbeStavkeSearchObject, NarudzbeStavkeInsertRequest, NarudzbeStavkeUpdateRequest>
	{
		public NarudzbeStavkeController(INarudzbeStavkeService service) : base(service)
		{

		}
	}
}
