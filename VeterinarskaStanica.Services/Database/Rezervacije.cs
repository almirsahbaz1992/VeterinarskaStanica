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

		public string PaymentId { get; set; } = null!;

		public int KorisnikId { get; set; }

		public int UslugaId { get; set; }

		public virtual Korisnici Korisnici { get; set; } = null!;

		public virtual Usluge Usluges { get; set; } = null!;
	}
}
