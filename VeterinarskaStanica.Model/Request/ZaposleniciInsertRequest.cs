﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class ZaposleniciInsertRequest
	{
		public string Ime { get; set; }

		public string Prezime { get; set; }
		public int RadnoMjestoId { get; set; }
		public DateTime DatumZaposlenja { get; set; }

		public float Plata { get; set; }
		public List<int> RadnoMjestoIdList { get; set; } = new List<int> { };
	}
}
