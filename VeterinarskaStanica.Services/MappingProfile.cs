using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model.Request;

namespace VeterinarskaStanica.Services
{
	public class MappingProfile : Profile
	{
		public MappingProfile() { 
			CreateMap<Database.Korisnici, Model.Korisnici>();
			CreateMap<Database.Proizvodi, Model.Proizvodi>();
			CreateMap<Database.JediniceMjere, Model.JediniceMjere>();
			CreateMap<Database.VrsteProizvodum, Model.VrstaProizvoda>();
			CreateMap<Database.KorisniciUloge, Model.KorisniciUloge>();
			CreateMap<Database.Uloge, Model.Uloge>();
			CreateMap<Database.Usluge, Model.Usluge>();
			CreateMap<Database.VrsteUsluga, Model.VrsteUsluga>();
			CreateMap<ProizvodiInsertRequest, Database.Proizvodi>();
			CreateMap<ProizvodiUpdateRequest, Database.Proizvodi>();
			CreateMap<UslugeInsertRequest, Database.Usluge>();
			CreateMap<UslugeUpdateRequest, Database.Usluge>();
			CreateMap<JediniceMjereUpsertRequest, Database.JediniceMjere>();
			CreateMap<VrstaProizvodaUpsertRequest, Database.VrsteProizvodum>();
			CreateMap<VrsteUslugaUpsertRequest, Database.VrsteUsluga>();
			CreateMap<KorisniciInsertRequest, Database.Korisnici>();
			CreateMap<KorisniciUpdateRequest, Database.Korisnici>();
			CreateMap<Database.Narudzbe, Model.Narudzbe>();
			CreateMap<NarudzbaInsertRequest, Database.Narudzbe>();
			CreateMap<NarudzbaUpdateRequest, Database.Narudzbe>();
		}
	}
}
