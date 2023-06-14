using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class UslugeInsertRequest
	{
		public string Naziv { get; set; }

		public string Sifra { get; set; }

		public decimal Cijena { get; set; }

		public int VrstaId { get; set; }

		public int JedinicaMjereId { get; set; }

		public byte[] Slika { get; set; }

		public byte[] SlikaThumb { get; set; }

		public bool? Status { get; set; }
		public string PaymentId { get; set; }

		public string StateMachine { get; set; }
		public List<int> VrsteIdList { get; set; } = new List<int> { };
		public List<int> JediniceMjereIdList { get; set; } = new List<int> { };
	}
}
