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
	public class UslugeService : BaseCRUDService<Model.Usluge, Database.Usluge, UslugeSearchObject, UslugeInsertRequest, UslugeUpdateRequest>, IUslugeService
	{
		public UslugeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{

		}
		public override IQueryable<Usluge> AddFilter(IQueryable<Usluge> query, UslugeSearchObject search = null)
		{
			var filteredQuery = base.AddFilter(query, search);
			if (!string.IsNullOrWhiteSpace(search?.Naziv))
			{
				filteredQuery = filteredQuery.Where(x => x.Naziv.Contains(search.Naziv)
				|| x.Naziv.Contains(search.Naziv));
			}
			if (!string.IsNullOrWhiteSpace(search?.Sifra))
			{
				filteredQuery = filteredQuery.Where(x => x.Sifra.Contains(search.Sifra)
				|| x.Sifra.Contains(search.Sifra));
			}
			return filteredQuery;
		}
	}
}
