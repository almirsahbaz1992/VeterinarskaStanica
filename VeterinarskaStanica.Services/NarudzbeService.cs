﻿using AutoMapper;
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
	public class NarudzbeService : BaseCRUDService<Model.Narudzbe, Database.Narudzbe, BaseSearchObject, NarudzbaInsertRequest, NarudzbaUpdateRequest>, INarudzbeService
	{
		public NarudzbeService(VeterinarskaStanicaContext context, IMapper mapper) : base(context, mapper)
		{
		}

		public override void BeforeInsert(NarudzbaInsertRequest insert, Narudzbe entity)
		{
			entity.KupacId = 1; //todo get from session
			entity.Datum = DateTime.Now;
			entity.BrojNarudzbe = (Context.Narudzbes.Count() + 1).ToString();
			base.BeforeInsert(insert, entity);
		}

		public override Model.Narudzbe Insert(NarudzbaInsertRequest insert)
		{
			var result = base.Insert(insert);
			foreach (var item in insert.Items)
			{
				//call context to store items
				Database.NarudzbaStavke dbItem = new NarudzbaStavke();
				dbItem.NarudzbaId = result.NarudzbaId;
				dbItem.ProizvodId = item.ProizvodId;
				dbItem.Kolicina = item.Kolicina;

				Context.NarudzbaStavkes.Add(dbItem);
			}

			Context.SaveChanges();
			return result;
		}
	}
}
