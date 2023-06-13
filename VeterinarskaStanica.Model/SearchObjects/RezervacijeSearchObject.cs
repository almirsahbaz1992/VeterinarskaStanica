using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.SearchObjects
{
	public class RezervacijeSearchObject : BaseSearchObject
	{
		public DateTime Datum { get; set; }
		public int? RezervacijaId { get; set; }
	}
}
