using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class NarudzbaInsertRequest
	{
		public int KorisnikId { get; set; }

		public int ProizvodId { get; set; }

		public DateTime Datum { get; set; }

		public bool Status { get; set; }
	}
}
