using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model
{
	public partial class Narudzbe
	{
		public int NarudzbaId { get; set; }
		public string BrojNarudzbe { get; set; }
		public int KupacId { get; set; }
		public DateTime Datum { get; set; }
		public bool Status { get; set; }
		public bool? Otkazano { get; set; }
	}
}
