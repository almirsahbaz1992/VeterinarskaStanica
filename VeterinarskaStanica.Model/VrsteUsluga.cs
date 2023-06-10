using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model
{
	public partial class VrsteUsluga
	{
		public int VrstaId { get; set; }

		public string Naziv { get; set; }

		public virtual ICollection<Usluge> Usluges { get; set; } = new List<Usluge>();
	}
}
