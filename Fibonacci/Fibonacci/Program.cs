
/* Project Name : Fibonacci
 *  Auther Name : Anita Poudyal
 *  Date: 8/12/19
 *  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = 1;
            int val3;
            int number;

            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            // Printing val1 and val 2
            Console.Write(val1 + " " + val2 + " ");
            for (int i = 0; i < number; i++)
            {
                val3 = val1 + val2;
               
                Console.Write( val3 + " ");
                val1 = val2;
                val2 = val3;
            }
            Console.ReadLine();

          
        }

    }
}
