using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Services.Database
{
	public partial class VrsteUsluga
	{
		public int VrstaId { get; set; }

		public string Naziv { get; set; } = null!;

		public virtual ICollection<Usluge> Usluges { get; set; } = new List<Usluge>();
	}
}
