using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2___Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetGCD(x, y));

            Console.ReadKey();
        }


        static int GetGCD(int x, int y)
        {
            while (Math.Max(x, y) % Math.Min(x, y) != 0)
            {
                int tmp = Math.Max(x, y) % Math.Min(x, y);
                if (x < y) y = tmp;
                else x = tmp;
            }

            return Math.Min(x, y);
        }

    }
}
