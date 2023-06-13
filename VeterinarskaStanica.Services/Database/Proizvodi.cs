using System;
using System.Collections.Generic;

namespace VeterinarskaStanica.Services.Database;

public partial class Proizvodi
{
    public int ProizvodId { get; set; }

    public string Naziv { get; set; } = null!;

    public string Sifra { get; set; } = null!;

    public decimal Cijena { get; set; }

	public string Opis { get; set; } = null!;
	public int VrstaId { get; set; }

    public int JedinicaMjereId { get; set; }

    public byte[]? Slika { get; set; }

    public byte[]? SlikaThumb { get; set; }

    public bool? Status { get; set; }

    public string? StateMachine { get; set; }

	public string PaymentId { get; set; } = null!;
	public virtual JediniceMjere JedinicaMjere { get; set; } = null!;

	public virtual ICollection<Narudzbe> Narudzbes { get; set; } = new List<Narudzbe>();

	public virtual VrsteProizvodum Vrsta { get; set; } = null!;
}
