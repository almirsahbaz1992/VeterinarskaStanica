﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model
{
	public partial class Usluge
	{
		public int UslugaId { get; set; }

		public string Naziv { get; set; }

		public string Sifra { get; set; }

		public decimal Cijena { get; set; }

		public string Opis { get; set; }
		public int VrstaId { get; set; }

		public int JedinicaMjereId { get; set; }


		public byte[] Slika { get; set; }

		public byte[] SlikaThumb { get; set; }

		public bool? Status { get; set; }
		public string PaymentId { get; set; }

		public string StateMachine { get; set; }

	}
}
