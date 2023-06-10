using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.SearchObjects
{
	public class RadnaMjestaSearchObject : BaseSearchObject
	{
		public string Naziv { get; set; }
		public int? RadnaMjestaId { get; set; }
	}
}
