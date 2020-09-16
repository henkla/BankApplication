using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationLibrary
{
    class Customer
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public long PersonalNumber { get; private set; }

		public void CreateAccount()
        {

        }

		public List<Account> Accounts { get; private set; } // NOT: inte implementerat klassen Account än

		public Customer(long pNr, string firstName, string lastName)
		{
			// todo; Kolla först så att pNr inte redan är registrerat i banken genom att anropa en funktion för detta
			PersonalNumber = pNr;
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
