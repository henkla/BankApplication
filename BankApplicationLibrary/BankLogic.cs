using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationLibrary
{
    public class BankLogic
    {
		public List<string> GetCustomers()
		{
			List<string> customers = new List<string>();
			return customers;
			// Returnerar en List<string> som innehåller en presentation av bankens alla kunder (personnummer och namn)
		}

		public bool AddCustomer(string name, long pNr)
		{
			bool addSuccess = false;
			return addSuccess;
			// Skapar en ny kund med namnet name samt personnummer pNr. Kunden skapas endast om det inte finns någon kund med personnummer pNr!
			// Returnerar true om kunden skapades, annars false
		}

		public List<string> GetCustomer(long pNr)
		{
			List<string> customerInfo = new List<string>();
			return customerInfo;
			//Returnerar en List<string> som innehåller informationen om kunden inklusive dennes konton. Första platsen i listan är förslagsvis
			// reserverad för kundens namn och personnummer, sedan följer informationen om kundens konton.
			// NOT: Vad händer om ett personnummer matas in som inte finns i bankens kundregister?
		}

		public bool ChangeCustomerName(string name, long pNr)
		{
			bool nameChangeSuccess = false;
			return nameChangeSuccess;
			//Byter namn på kund med personnummer pNr till name, returnerar true
			//om namnet ändrades annars returnerar false (om kunden inte fanns).
		}

		public List<string> RemoveCustomer(long pNr)
		{
			//Tar bort kund med personnummer pNr ur banken, alla kundens
			//eventuella konton tas också bort och resultatet returneras. Listan som
			//returneras ska innehålla information om alla konton som togs bort,
			//saldot som kunden får tillbaka samt vad räntan blev.

			List<string> deletedCustomerInfo = new List<string>();
			return deletedCustomerInfo;
		}

		public int AddSavingsAccount(long pNr)
		{
			//Skapar ett konto till kund med personnummer pNr, returnerar
			//kontonumret som det skapade kontot fick alternativt returneras –1 om
			//inget konto skapades.

			int accountNumber = -1;
			return accountNumber;
		}

		public string GetAccount(long pNr, int accountId)
		{
			//Returnerar en string som innehåller presentation av kontot med
			//kontonnummer accountId som tillhör kunden pNr (kontonummer,
			//saldo, kontotyp, räntesats).

			string accountPresentation = "";
			return accountPresentation;
		}

		public bool Deposit(long pNr, int accountId, decimal amount)
		{
			//Gör en insättning på konto med kontonnummer accountId som tillhör
			//kunden pNr, returnerar true om det gick bra annars false.

			bool depositSuccess = false;
			return depositSuccess;
		}

		public bool Withdraw(long pNr, int accountId, decimal amount)
		{
			// Gör ett uttag på konto med kontonnummer accountId som tillhör
			// kunden pNr, returnerar true om det gick bra annars false

			bool withdrawSuccess = false;
			return withdrawSuccess;
		}

		public string CloseAccount(long pNr, int accountId)
		{
			//Stänger ett konto med kontonnummer accountId som tillhör kunden
			//pNr, presentation av kontots saldo samt ränta på pengarna ska
			//genereras.

			string closedAccountInfo = "";
			return closedAccountInfo;
		}
	}
}
