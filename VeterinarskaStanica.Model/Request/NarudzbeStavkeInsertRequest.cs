using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class NarudzbeStavkeInsertRequest
	{
		public int NarudzbaId { get; set; }

		public int ProizvodId { get; set; }

		public int Kolicina { get; set; }

		public List<int> ProizvodIdList { get; set; } = new List<int> { };
		public List<int> NarudzbaIdList { get; set; } = new List<int> { };
	}
}
