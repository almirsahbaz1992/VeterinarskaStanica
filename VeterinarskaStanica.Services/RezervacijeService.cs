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
	public class RezervacijeService : BaseCRUDService<Model.Rezervacije, Database.Rezervacije, RezervacijeSearchObject, RezervacijeInsertRequest, RezervacijeUpdateRequest>, IRezervacijeService

	{
		public RezervacijeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override IQueryable<Rezervacije> AddFilter(IQueryable<Rezervacije> query, RezervacijeSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (search?.Datum == null)
			{
				filteredQuery = filteredQuery.Where(x => x.DatumRezervacije == search.Datum
				|| x.DatumRezervacije == search.Datum);
			}
			return filteredQuery;
		}
	}
}
