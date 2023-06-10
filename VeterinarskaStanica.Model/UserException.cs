using System;
using System.Collections.Generic;
using System.Text;

namespace VeterinarskaStanica.Model
{
	public class UserException : Exception
	{
		public UserException(string message): base(message) 
		{
			
		}
	}
}
