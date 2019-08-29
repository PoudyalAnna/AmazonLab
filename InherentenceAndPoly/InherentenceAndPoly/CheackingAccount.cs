using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherentenceAndPoly
{
    // inhetited from Account class, child slass Checking Account
    class CheackingAccount : Account
    {
        public  CheackingAccount(decimal initalBalance) : base(initalBalance) 
            {

            } 
            public override Transaction withdrawal(decimal amount)
            {
            Transaction thisTransaction = new Transaction();
           thisTransaction.AccoutNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.isSuccessful = false;
            thisTransaction.TimeStamp = DateTime.Now;

            // tru to process transaction

            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction Failed: Insufficient Funds.";
                Console.WriteLine("Transaction Failed: Insufficient Funds");
            }
            else
            {
                Balance -= amount; //Balance= balance - amount
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = string.Format("Account#: {0} was debited {1}",  thisTransaction.AccoutNumber, thisTransaction.Amount);
                Console.WriteLine("Successfully Withdrew from" + thisTransaction.AccoutNumber + "debited amount of" + thisTransaction.Amount);

            }

            
            return thisTransaction;
            }
    }
}
