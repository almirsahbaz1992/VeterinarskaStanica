﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinarskaStanica.Model.Request;
using VeterinarskaStanica.Model.SearchObjects;

namespace VeterinarskaStanica.Services
{
	public interface IZaposleniciService : ICRUDService<VeterinarskaStanica.Model.Zaposlenici, ZaposleniciSearchObject, ZaposleniciInsertRequest, ZaposleniciUpdateRequest>
	{
	}
}
