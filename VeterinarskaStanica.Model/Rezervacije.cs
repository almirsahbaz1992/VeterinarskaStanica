﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Model
{
	public partial class Rezervacije
	{
		public int RezervacijeId { get; set; }

		public DateTime DatumRezervacije { get; set; }

		public string PaymentId { get; set; }

		public int KorisnikId { get; set; }
		public int UslugaId { get; set; }
	}
}
