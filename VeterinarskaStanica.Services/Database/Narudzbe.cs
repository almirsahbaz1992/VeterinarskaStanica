using System;
using System.Collections.Generic;

namespace VeterinarskaStanica.Services.Database;

public partial class Narudzbe
{
    public int NarudzbaId { get; set; }

    public int KorisnikId { get; set; }

	public int ProizvodId { get; set; }

	public DateTime Datum { get; set; }

    public bool Status { get; set; }

    public virtual Korisnici Korisnik { get; set; } = null!;

	public virtual Proizvodi Proizvod { get; set; } = null!;
}
