using System;
using System.Collections.Generic;

namespace VeterinarskaStanica.Services.Database;

public partial class Korisnici
{
    public int KorisnikId { get; set; }

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefon { get; set; }

    public string KorisnickoIme { get; set; } = null!;

    public string LozinkaHash { get; set; } = null!;

    public string LozinkaSalt { get; set; } = null!;

    public bool? Status { get; set; }

    public virtual ICollection<KorisniciUloge> KorisniciUloges { get; set; } = new List<KorisniciUloge>();
	public virtual ICollection<Narudzbe> Narudzbes { get; set; } = new List<Narudzbe>();

	public virtual ICollection<Rezervacije> Rezervacijes { get; set; } = new List<Rezervacije>();
}
