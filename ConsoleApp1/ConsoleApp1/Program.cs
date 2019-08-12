using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            int nLargest;
            int nSmallest;
            int nCurrent;
            string strQuit;


            // first integer
            Console.WriteLine("Enter an  integer");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter other no of Q to quit");
            strQuit = Console.ReadLine();


            //loop
            while (strQuit != "Q" )
            {
                nCurrent = Convert.ToInt32(strQuit);

                // check to see if input should replace or smallert

            if(nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
            else if (nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }

                Console.WriteLine("Enter other no of Q to quit");
                strQuit = Console.ReadLine();              
            }

            Console.WriteLine("The largre no is: " + nLargest + ".");
            Console.WriteLine("The small no is: " + nSmallest + ".");
            Console.ReadLine();

        }
    }
}