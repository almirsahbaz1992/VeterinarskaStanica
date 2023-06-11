using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Services.Database
{
	public partial class ZaposleniciRadnaMjesta
	{
		public int ZaposlenikRadnoMjestoId { get; set; }

		public int ZaposlenikId { get; set; }

		public int RadnoMjestoId { get; set; }

		public virtual Zaposlenici Zaposlenik { get; set; } = null!;

		public virtual RadnaMjesta RadnoMjesto { get; set; } = null!;
	}
}
