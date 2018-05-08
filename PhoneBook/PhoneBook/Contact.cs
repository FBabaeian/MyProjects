using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
	class Contact
	{
			public string Name { get; set; }
			public string Family { get; set; }
			
			public string Phone { get; set; }

			public Contact(string name, string family, string phone)
			{
				Name = name;
				Family = family;
				Phone = phone;
			}
		}
	}

