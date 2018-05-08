using System;

namespace PhoneBook
{
	class Program
	{
		static void Main(string[] args)
		{

			PhoneBook phoneBook = new PhoneBook();

			PromptUser();

			void Menu()
			{
				Console.WriteLine("TYPE:");
				Console.WriteLine("'Add' to add a contact: ");
				Console.WriteLine("'View' to view the list of contacts: ");
				Console.WriteLine("'Remove' to select and remove a contact: ");
				Console.WriteLine("'Update' to select and update a contact: ");
				Console.WriteLine("'Quit' at anytime to exit: ");
			}

			void AddPhonesBook(string userInput)
			{
				string name = "";
				string family = "";
				string phone = "";
				switch (userInput.ToLower())
				{
					case "add":
						Console.Write("Enter a name: ");
						name = Console.ReadLine().Trim();
						switch (name)
						{
							case "quit":
								break;
							default:
								Console.Write("Enter a family: ");
								family = Console.ReadLine().Trim();
								//phone = Console.ReadLine().Trim();
								switch (family)
								{
									case "quit":
										break;
									default:
										Console.Write("Enter a phone: ");
										phone = Console.ReadLine().Trim();
										switch (phone)
										{
											case "quit":
												break;
											default:
												phoneBook.AddEntry(name, family, phone);
												break;
										}
										break;
								}
								
								
								break;
						}
						break;
					case "remove":
						Console.Write("Enter a name to remove: ");
						name = Console.ReadLine();
						switch (name)
						{
							case "quit":
								break;
							default:
								phoneBook.RemoveEntry(name);
								break;
						}
						break;
					case "view":
						Console.WriteLine(phoneBook.ViewContactsList());
						break;
					case "update":
						Console.WriteLine("Please enter the name of the Contact you like to update");
						name = Console.ReadLine();
						phoneBook.UpdateContact(name);
						break;
				}
			}

			void PromptUser()
			{
				Menu();
				string userInput = "";
				while (userInput != "quit")
				{
					Console.WriteLine("What would you like to do?");
					userInput = Console.ReadLine().Trim();
					AddPhonesBook(userInput);
				}
			}
		}
	}
}