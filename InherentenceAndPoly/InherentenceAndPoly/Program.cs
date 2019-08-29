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
            Console.WriteLine(myAccount.GetType());


            Console.ReadLine();
        }
    }
}
