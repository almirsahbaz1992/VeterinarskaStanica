using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class RezervacijeInsertRequest
	{
		public DateTime DatumRezervacije { get; set; }

		public string PaymentId { get; set; }

		public int KorisnikId { get; set; }
		public int UslugaId { get; set; }

		public List<int> KorisniciIdList { get; set; } = new List<int> { };

		public List<int> UslugaIdList { get; set; } = new List<int> { };
	}
}
