using System;
using System.Collections.Generic;

namespace VeterinarskaStanica.Services.Database;

public partial class Narudzbe
{
    public int NarudzbaId { get; set; }
	public string BrojNarudzbe { get; set; } = null!;

	public int KorisnikId { get; set; }

	public DateTime Datum { get; set; }

    public bool Status { get; set; }
	public bool? Otkazano { get; set; }
	public string PaymentId { get; set; } = null!;

	public virtual Korisnici Korisnik { get; set; } = null!;

	public virtual ICollection<NarudzbaStavke> NarudzbaStavkes { get; set; } = new List<NarudzbaStavke>();
}
