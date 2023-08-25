﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace VeterinarskaStanica.Model
{
	public partial class Korisnici
	{
		public int KorisnikId { get; set; }

		public string Ime { get; set; }

		public string Prezime { get; set; }
		public string Email { get; set; }

		public string Telefon { get; set; }

		public string KorisnickoIme { get; set; }

        public bool? Status { get; set; }

		public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; } = new List<KorisniciUloge>();
		public virtual ICollection<Narudzbe> Narudzbes { get; set; } = new List<Narudzbe>();
		public string RoleNames => string.Join (", ", KorisniciUloges?.Select(x => x.Uloga?.Naziv)?.ToList());
	}
}
