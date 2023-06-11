using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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

		public virtual RadnaMjesta RadnaMjesta { get; set; }
	}
}
