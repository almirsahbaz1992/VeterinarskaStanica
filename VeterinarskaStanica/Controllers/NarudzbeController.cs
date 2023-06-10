using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;

namespace VeterinarskaStanica.Controllers
{
	public class NarudzbeController : BaseCRUDController<Model.Narudzbe, BaseSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>
	{
		public NarudzbeController(INarudzbeService service)
			: base(service)
		{
		}
	}
}
