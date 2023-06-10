using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.SearchObjects
{
	public class UslugeSearchObject : BaseSearchObject
	{
		public string Naziv { get; set; }
		public string Sifra { get; set; }
		public int? UslugaID { get; set; }
	}
}