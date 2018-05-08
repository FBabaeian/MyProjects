using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
	class PhoneBook
	{
		public  Contact[] contacts;

		public PhoneBook()
		{
			contacts = new Contact[2]; ;
		}

		public bool AddEntry(string name, string family,string phone)
		{
			if (!ContainsEntry(name))
			{
			
				Contact AddContact = new Contact(name, family,phone);
				for (int i = 0; i < contacts.Length; i++)
				{
					if (contacts[i] == null)
					{
						contacts[i] = AddContact;
						Console.WriteLine("Phone Book updated. Name: {0} -- Family: {1} -- Phone:{2} has been added!", name, family,phone);
						return true;
					}
				}
				Console.WriteLine($"Cannot add ({name}) to Phone Book since it is full!");
				return false;
			}
				else
				{
					Console.WriteLine($"({name}) already exists in PhoneBook!");
					UpdateContact(name);
				}
				return false;
		}

		public bool UpdateContact(string Name)
		{
			Console.Write("Are you sure you would you like to update the Contact? -- Type 'Y' or 'N': ");
			string userResponse = Console.ReadLine().ToLower();
			if (userResponse == "y")
			{
				Console.Write($"Would you like to update {Name}'s name or family or Phone? TYPE - 'Name' for name and 'Family' for family and 'Phone' for phone: ");
				string contactToUpdate = Console.ReadLine().ToLower();

				Console.Write($"Please enter changes to the {contactToUpdate} here: ");
				string updatedContact = Console.ReadLine().Trim();
				

				int index = GetEntryIndex(Name);
				switch (contactToUpdate)
				{
					case "name":
						contacts[index].Name = updatedContact;
						Console.WriteLine($"Contact {Name} updated to {updatedContact}");
						return true;
					case "family":
						contacts[index].Family = updatedContact;
						Console.WriteLine($"Contact {Name}'s {contactToUpdate} updated to {updatedContact}");
						return true;
					case "phone":
						contacts[index].Phone = updatedContact;
						Console.WriteLine($"Contact {Name}'s {contactToUpdate} updated to {updatedContact}");
						return true;
				}
			}
			return false;
		}

	

		private int GetEntryIndex(string name)
		{
			for (int i = 0; i < contacts.Length; i++)
			{
				if (contacts[i] != null && contacts[i].Name.ToLower() == name.ToLower())
					return i;
			}
			return -1;
		}

		private bool ContainsEntry(string name)
		{
			return GetEntryIndex(name) != -1;
		}

		public void RemoveEntry(string name)
		{
			var index = GetEntryIndex(name);
			if (index != -1)
			{
				contacts[index] = null;
				Console.WriteLine("{0} removed from contacts", name);
			}
		}

		public string ViewContactsList()
		{
			string contactList = "";
			foreach (Contact contact in contacts)
			{
				if (contact == null)
				{
					continue;
				}
				contactList += String.Format("Name: {0} -- Family: {1} -- phone: {2}" + Environment.NewLine, contact.Name, contact.Family,contact.Phone);
			}
			return (contactList != String.Empty) ? contactList : "Your phone Book is empty.";
		}
	}
}

