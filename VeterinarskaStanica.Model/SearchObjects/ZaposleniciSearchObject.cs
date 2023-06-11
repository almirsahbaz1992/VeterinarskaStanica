using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.SearchObjects
{
	public class ZaposleniciSearchObject : BaseSearchObject
	{
		
		public string Ime { get; set; }

		public string Prezime { get; set; } 
		public RadnaMjesta RadnoMjesto { get; set; }
		public DateTime DatumZaposlenja { get; set; }

		public float Plata { get; set; }

		public int? ZaposlenikID { get; set; }

	}
}
