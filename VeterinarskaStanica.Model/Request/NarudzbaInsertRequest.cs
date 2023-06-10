using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class NarudzbaInsertRequest
	{
		public List<NarudzbaStavkeInsertRequest> Items { get; set; } = new List<NarudzbaStavkeInsertRequest>();
	}
}
