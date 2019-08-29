using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherentenceAndPoly
    {
    // Polymorphism INplementation
    class Program      
    {
        static void Main(string[] args)
        {
            Account myAccount;
            myAccount = new CheackingAccount(1000);
            myAccount.withdrawal(500);
            Console.WriteLine(myAccount.GetType());

            myAccount = new SavingAccount(2000, 0);
            myAccount.withdrawal(1500);
            myAccount.Deposit(500);


            SavingAccount mySav = new SavingAccount(1000, 2);
            mySav.interestRate = 0.10m;
            mySav.ProcessProfit();
            Console.WriteLine("profit" + mySav.Balance);
            Console.WriteLine(myAccount.Balance);           
            Console.WriteLine(myAccount.GetType());


            Console.ReadLine();
        }
    }
}
