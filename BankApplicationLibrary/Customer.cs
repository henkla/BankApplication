using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationLibrary
{
    class Customer
    {
	    private BankLogic _bankLogic; 
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

		public Customer(BankLogic bankLogic, long pNr, string firstName, string lastName)
		{
			// todo; Kolla först så att pNr inte redan är registrerat i banken genom att anropa en funktion för detta
			_bankLogic ?? throw new ArgumentNullException("BankLogic får inte vara null."); 
			
			_bankLogic = bankLogic;
			
			if (_bankLogic.CustomerExists(pNr)) 
			{ 
				throw new ApplicationExecption($"En kund med personnummer {pNr} finns redan registrerad som kund."); 
			}
			PersonalNumber = pNr;
			FirstName = firstName;
			LastName = lastName;
		}
	}
}
