using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InherentenceAndPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            CheackingAccount mycheackingAccout = new CheackingAccount(1000);
            Console.WriteLine("Intitial withdraw of $250");
            mycheackingAccout.Withdeawl(250);
          //  Console.ReadLine();
          

           
            Console.WriteLine("Intitial withdraw of850");
            mycheackingAccout.Withdeawl(850);
            Console.ReadLine();
        }
    }
}
