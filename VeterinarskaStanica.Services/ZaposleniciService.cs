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
			if (!string.IsNullOrEmpty(search?.Ime))
			{
				filteredQuery = filteredQuery.Where(x => x.Ime == search.Ime);
			}
			if (search?.ZaposlenikID.HasValue == true)
			{
				filteredQuery = filteredQuery.Where(x => x.ZaposlenikID == search.ZaposlenikID);
			}
			return filteredQuery;
		}
	}
}
