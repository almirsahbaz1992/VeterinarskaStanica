using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model
{
	public partial class Zaposlenici
	{
		public int ZaposlenikID { get; set; }

		public string Ime { get; set; }

		public string Prezime { get; set; }
		public int RadnoMjestoId { get; set; }
		public DateTime DatumZaposlenja { get; set; }

		public float Plata { get; set; }
	}
}
