using System;
using System.Collections.Generic;

namespace VeterinarskaStanica.Model
{
    public partial class Proizvodi
    {
        public int ProizvodId { get; set; }

        public string Naziv { get; set; }

        public string Sifra { get; set; }

        public decimal Cijena { get; set; }

		public string Opis { get; set; }

		public int VrstaId { get; set; }

        public int JedinicaMjereId { get; set; }

        public byte[] Slika { get; set; }

        public byte[] SlikaThumb { get; set; }

        public bool? Status { get; set; }

		public string PaymentId { get; set; }

		public string StateMachine { get; set; }

		public virtual ICollection<Narudzbe> Narudzbes { get; set; } = new List<Narudzbe>();
	}
}