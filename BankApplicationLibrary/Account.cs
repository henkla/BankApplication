using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationLibrary
{
    class Account
    {
        public int Id { get; set; } // Kontonummer
        public decimal Balance { get; set; } // Saldo
        public decimal Interest
        {
            get
            {
                return Balance * InterestRate / 100;
            }
        }
        public decimal InterestRate { get; set; } // Ränta i %
        public string AccountType { get; set; } // Kontotyp

        protected int GenerateAccountId()
        {
            int accountNumber = 1000;
            return accountNumber;
        }

        public List<string> Present()
        {
            // presentera kontot(kontonummer,saldo, kontotyp, räntesats).
            List<string> accountInfo = new List<string>();
            return accountInfo;
        }

        private string PresentValue(decimal input)
        // Hjälpfunktion för att runda av decimal till 2 decimaler, typ "6,54" och sedan konvertera dem till string
        // för att kunna skrivas ut till en List<string> med Present()
        {
            input = Math.Round(input, 2);
            return Convert.ToString(input);
        }
    }
}
