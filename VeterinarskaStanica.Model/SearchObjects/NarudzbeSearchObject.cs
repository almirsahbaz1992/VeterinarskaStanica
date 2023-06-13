using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.SearchObjects
{
	public class NarudzbeSearchObject : BaseSearchObject
	{
		public string BrojNarudzbe { get; set; }
		public DateTime Datum { get; set; }
		public int? NarudzbaId { get; set; }
	}
}
