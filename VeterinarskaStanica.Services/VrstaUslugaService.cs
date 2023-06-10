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
	public class VrstaUslugaService : BaseCRUDService<Model.VrsteUsluga, Database.VrsteUsluga, VrsteUslugaSearchObject, VrsteUslugaUpsertRequest, VrsteUslugaUpsertRequest>, IVrsteUslugaService
	{
		public VrstaUslugaService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{

		}
		public override IQueryable<VrsteUsluga> AddFilter(IQueryable<VrsteUsluga> query, VrsteUslugaSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (!string.IsNullOrWhiteSpace(search?.NazivGT))
			{
				filteredQuery = filteredQuery.Where(x => x.Naziv.StartsWith(search.NazivGT));
			}
			return filteredQuery;
		}
	}
}