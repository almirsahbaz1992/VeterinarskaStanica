using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Services.Database
{
	public partial class RadnaMjesta
	{
		public int RadnaMjestaId { get; set; }

		public string Naziv { get; set; } = null!;

		public virtual ICollection<Zaposlenici> Zaposlenicis { get; set; } = new List<Zaposlenici>();
	}
}
