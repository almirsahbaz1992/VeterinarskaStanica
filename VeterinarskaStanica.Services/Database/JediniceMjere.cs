using System;
using System.Collections.Generic;

namespace VeterinarskaStanica.Services.Database;

public partial class JediniceMjere
{
    public int JedinicaMjereId { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Proizvodi> Proizvodis { get; set; } = new List<Proizvodi>();
	public virtual ICollection<Usluge> Usluges  { get; set; } = new List<Usluge>();
}
