using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationLibrary
{
    class SavingsAccount : Account
    {

		/*
		Man ska kunna utföra transaktioner (insättning/uttag), hämta kontonummer,
		beräkna ränta (saldo * räntesats/100) samt presentera kontot (kontonummer,
		saldo, kontotyp, räntesats).
		*/

		public SavingsAccount(Customer customer)
        {
			Id = GenerateAccountId();
			Balance = 0;
			InterestRate = 1;
			AccountType = "SparKonto";
        }

	}
}
