using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___Parallel_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = {"Rick Sanchez", "Monty Smith","Jerry Smith",
            "Beth Smith", "Summer Smith"};
            string[] Phones = { "555-1334", "555_3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;

            // promt user
            Console.WriteLine("Type a name to search from in the phone book: ");
            strSearch = Console.ReadLine();

            for(int n=0; n < Names.Length; n++)
            {
                if(Names[n].IndexOf(strSearch)> -1)
                {
                    Console.WriteLine(Names[n] + " ->" + Phones[n]);

                }
            }
            Console.ReadLine();
        }
    }
}
