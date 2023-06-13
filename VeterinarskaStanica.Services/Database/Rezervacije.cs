using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Services.Database
{
	public partial class Rezervacije
	{
		public int RezervacijeId { get; set; }

		public DateTime DatumRezervacije { get; set; }

		public virtual ICollection<Usluge> Usluge { get; set; } = new List<Usluge>();
	}
}
