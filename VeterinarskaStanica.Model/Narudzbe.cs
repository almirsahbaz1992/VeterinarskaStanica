using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model
{
	public partial class Narudzbe
	{
		public int NarudzbaId { get; set; }
		public int KorisnikId { get; set; }
		public int ProizvodId { get; set; }
		public DateTime Datum { get; set; }
		public bool Status { get; set; }
	}
}
