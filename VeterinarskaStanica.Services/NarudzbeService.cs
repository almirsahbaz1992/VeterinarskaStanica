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
	public class NarudzbeService : BaseCRUDService<Model.Narudzbe, Database.Narudzbe, NarudzbeSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>, INarudzbeService
	{
		public NarudzbeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override IQueryable<Narudzbe> AddFilter(IQueryable<Narudzbe> query, NarudzbeSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
			{
				filteredQuery = filteredQuery.Where(x => x.BrojNarudzbe.Contains(search.BrojNarudzbe)
				|| x.BrojNarudzbe.Contains(search.BrojNarudzbe));
			}
			if (search?.Datum == null)
			{
				filteredQuery = filteredQuery.Where(x => x.Datum == search.Datum
				|| x.Datum == search.Datum);
			}
			return filteredQuery;
		}
	}
}
