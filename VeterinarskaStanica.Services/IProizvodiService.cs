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
	public interface IProizvodiService : ICRUDService<VeterinarskaStanica.Model.Proizvodi, ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
	{
		Model.Proizvodi Activate(int id);
		List<string> AllowedActions(int id);

		List<Model.Proizvodi> Recommend (int id);
	}
}
