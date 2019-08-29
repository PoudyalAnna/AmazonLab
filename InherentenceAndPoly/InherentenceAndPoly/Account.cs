using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherentenceAndPoly
{
      abstract class Account
    {

        // Inheritence
        //parent class
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        // set out account balance, initial balance value using constructor
        public Account (decimal initalBalanc)
        {
            Balance = initalBalanc;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        //child class can implement its own withdrawal methiod with custom logic

        public abstract Transaction withdrawal(decimal amount);
    }
}
