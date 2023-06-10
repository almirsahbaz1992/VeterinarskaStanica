using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services.Database;

namespace VeterinarskaStanica.Services
{
	public class JediniceMjereService : BaseCRUDService<Model.JediniceMjere, Database.JediniceMjere, JediniceMjereSearchObject, JediniceMjereUpsertRequest, JediniceMjereUpsertRequest>, IJediniceMjereService
	{
		public JediniceMjereService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper) 
		{
	
		}
		public override IQueryable<JediniceMjere> AddFilter(IQueryable<JediniceMjere> query, JediniceMjereSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if(!string.IsNullOrEmpty(search?.Naziv)) 
			{
				filteredQuery = filteredQuery.Where(x => x.Naziv == search.Naziv);
			}
			if(search?.JediniceMjereId.HasValue == true)
			{
				filteredQuery = filteredQuery.Where(x => x.JedinicaMjereId == search.JediniceMjereId);
			}
			return filteredQuery;
		}
	}
}
