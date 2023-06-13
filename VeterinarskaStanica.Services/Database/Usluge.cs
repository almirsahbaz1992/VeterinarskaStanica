using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarskaStanica.Services.Database
{
	public partial class Usluge
	{
		public int UslugaId { get; set; }

		public string Naziv { get; set; } = null!;

		public string Sifra { get; set; } = null!;

		public decimal Cijena { get; set; }
		public int VrstaId { get; set; }

		public int JedinicaMjereId { get; set; }

		public byte[]? Slika { get; set; }

		public byte[]? SlikaThumb { get; set; }

		public bool? Status { get; set; }

		public string? StateMachine { get; set; }

		public string PaymentId { get; set; } = null!;

		public virtual JediniceMjere JedinicaMjere { get; set; } = null!;

		public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; } = new List<NarudzbaStavke>();

		public virtual VrsteUsluga Usluga { get; set; } = null!;
	}
}
