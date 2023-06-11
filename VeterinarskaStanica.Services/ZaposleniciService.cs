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
	public class ZaposleniciService : BaseCRUDService<Model.Zaposlenici, Database.Zaposlenici, ZaposleniciSearchObject, ZaposleniciInsertRequest, ZaposleniciUpdateRequest>, IZaposleniciService
	{
		public ZaposleniciService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{

		}
		public override IQueryable<Zaposlenici> AddFilter(IQueryable<Zaposlenici> query, ZaposleniciSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (!string.IsNullOrWhiteSpace(search?.Ime))
			{
				filteredQuery = filteredQuery.Where(x => x.Ime.Contains(search.Ime)
				|| x.Ime.Contains(search.Ime));
			}
			if (!string.IsNullOrWhiteSpace(search?.Prezime))
			{
				filteredQuery = filteredQuery.Where(x => x.Prezime.Contains(search.Prezime)
				|| x.Prezime.Contains(search.Prezime));
			}
			return filteredQuery;
		}
	}
}
