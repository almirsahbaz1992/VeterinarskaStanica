using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;

namespace VeterinarskaStanica.Services
{
	public interface INarudzbeService : ICRUDService<VeterinarskaStanica.Model.Narudzbe, NarudzbeSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>
	{

	}
}
