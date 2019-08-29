using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherentenceAndPoly
{
    class SavingAccount : Account
    {
        private const int MONTHLY_WITHDRAW_LIMIT = 5;
        public decimal interestRate { get; set; }

        public int WithdrawlsThisMonth {get; set;}

        // set the intitila Balance

        public SavingAccount (decimal initialBalance, int withdeawlsThidMonth) : base(initialBalance)
        {
           WithdrawlsThisMonth = withdeawlsThidMonth;

        }
        public override Transaction withdrawal(decimal amount)
        {
            // implement the withdrawl transaction logic here
            Transaction thisTransaction = new Transaction();
            thisTransaction.AccoutNumber = AccountNumber;
            thisTransaction.Amount = amount;
            thisTransaction.TimeStamp = DateTime.Now;
            thisTransaction.isSuccessful = false;

            // perform withdeawals

            if (amount > Balance)
            {
                thisTransaction.Detail = "Transaction Failed: Insufficient balance." + Balance;
                Console.WriteLine("Transaction Failed: Insufficient Funds");
            }
            else if (WithdrawlsThisMonth > MONTHLY_WITHDRAW_LIMIT)
            {
                thisTransaction.Detail = "Transaction failed, INsufficient Balance.";
                Console.WriteLine("Transaction Failed: due to monthly withdrawal limit");
            }
            else
            {
                Balance -= amount; //Balance= balance - amount
                thisTransaction.isSuccessful = true;
                thisTransaction.Detail = "Debit transaction for account number" + AccountNumber +" with the amount of $" + amount; 
                Console.WriteLine(thisTransaction.Detail);

            }



            return thisTransaction;
        }

        public void ProcessProfit()
        {
            Balance += Balance + interestRate;
        }
    }
}
