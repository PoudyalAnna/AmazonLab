using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firsNo;
            int secNo;
            int thirdNo;

            Console.WriteLine("Please enter first no: ");
            firsNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second no: ");
            secNo = Convert.ToInt32(Console.ReadLine());

            if(firsNo < secNo)
            {
                Console.WriteLine("The big no is: " + secNo);
            }
            else
            {
                Console.WriteLine("The big no is: " + firsNo);
            }

            Console.WriteLine("Please enter third no: ");
            thirdNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(firsNo, Math.Max(secNo, thirdNo)));
            Console.WriteLine("Lowest of three: " + Math.Min(firsNo, Math.Min(secNo, thirdNo)));

            Console.ReadLine();

        }
    }
}