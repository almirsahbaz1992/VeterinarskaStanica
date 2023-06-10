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
	public class RadnaMjestaService : BaseCRUDService<Model.RadnaMjesta, Database.RadnaMjesta, RadnaMjestaSearchObject, RadnaMjestaUpsertRequest, RadnaMjestaUpsertRequest>, IRadnaMjestaService
	{
		public RadnaMjestaService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{

		}
		public override IQueryable<RadnaMjesta> AddFilter(IQueryable<RadnaMjesta> query, RadnaMjestaSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (!string.IsNullOrEmpty(search?.Naziv))
			{
				filteredQuery = filteredQuery.Where(x => x.Naziv == search.Naziv);
			}
			if (search?.RadnaMjestaId.HasValue == true)
			{
				filteredQuery = filteredQuery.Where(x => x.RadnaMjestaId == search.RadnaMjestaId);
			}
			return filteredQuery;
		}
	}
}
