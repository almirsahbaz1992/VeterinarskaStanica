using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VeterinarskaStanica.Model.Request
{
	public class KorisniciInsertRequest
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }

		public string Telefon { get; set; }
		public string KorisnickoIme { get; set; }
		public string Password { get; set; }

		public string PasswordPotvrda { get; set; }
		public bool? Status { get; set; }

		public List<int> UlogeIdList { get; set; } = new List<int> { };
		public List<int> KorisniciIdList { get; set; } = new List<int> { };
	}
}
