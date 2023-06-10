using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class NarudzbaStavkeInsertRequest
	{
		public int ProizvodId { get; set; }
		public int Kolicina { get; set; }
	}
}
