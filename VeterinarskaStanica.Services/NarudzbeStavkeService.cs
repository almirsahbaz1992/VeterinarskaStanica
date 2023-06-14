using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services.Database;

namespace VeterinarskaStanica.Services
{
	public class NarudzbeStavkeService : BaseCRUDService<Model.NarudzbaStavke, Database.NarudzbaStavke, NarudzbeStavkeSearchObject, NarudzbeStavkeInsertRequest, NarudzbeStavkeUpdateRequest>, INarudzbeStavkeService
	{
		public NarudzbeStavkeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{

		}
	}
}
