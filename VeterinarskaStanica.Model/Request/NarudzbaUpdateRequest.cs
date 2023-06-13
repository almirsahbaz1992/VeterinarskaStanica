using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class NarudzbaUpdateRequest
	{

		public DateTime Datum { get; set; }

		public bool Status { get; set; }

		public bool? Otkazano { get; set; }
	}
}
