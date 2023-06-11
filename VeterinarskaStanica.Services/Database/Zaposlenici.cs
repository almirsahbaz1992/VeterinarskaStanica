using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Services.Database
{
	public partial class Zaposlenici
	{
		public int ZaposlenikID { get; set; }

		public string Ime { get; set; } = null!;

		public string Prezime { get; set; } = null!;
		public int RadnoMjestoId { get; set; }
		public DateTime DatumZaposlenja { get; set; }

		public float Plata { get; set; }

		public virtual RadnaMjesta RadnaMjesta { get; set; } = null!;
		public virtual ICollection<ZaposleniciRadnaMjesta> ZaposleniciRadnaMjestas { get; set; } = new List<ZaposleniciRadnaMjesta>();

	}
}
