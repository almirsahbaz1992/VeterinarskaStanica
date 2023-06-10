using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services.Database;

namespace VeterinarskaStanica.Services
{
	public class VrsteProizvodaService : BaseCRUDService<Model.VrstaProizvoda, Database.VrsteProizvodum, VrstaProizvodaSearchObject, VrstaProizvodaUpsertRequest, VrstaProizvodaUpsertRequest>, IVrsteProizvodaService
	{
		public VrsteProizvodaService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{

		}
		public override IQueryable<VrsteProizvodum> AddFilter(IQueryable<VrsteProizvodum> query, VrstaProizvodaSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if(!string.IsNullOrWhiteSpace(search?.NazivGT))
			{
				filteredQuery = filteredQuery.Where(x => x.Naziv.StartsWith(search.NazivGT));
			}
			return filteredQuery;
		}
	}
}
