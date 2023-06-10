using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class ZaposleniciUpdateRequest
	{
		public string Prezime { get; set; }
		public int RadnoMjestoId { get; set; }
		public float Plata { get; set; }
	}
}
