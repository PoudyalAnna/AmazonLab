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
            string[] DaysOfsWeek = { "Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri" };
            string[] arrWek = new string[7];
            string name = "The edg tech";
            Console.WriteLine(DaysOfsWeek.Length.ToString());

            foreach(string day in DaysOfsWeek)
            {
                Console.WriteLine("the day in week" + day);
            }



            for (int val1 = 0; val1 <= DaysOfsWeek.Length; val1++)
            {
                Console.WriteLine("the day in week inside for loop: " + DaysOfsWeek[val1]);

            }

            string newString = name.Insert(8, ">HELLO!<");
            Console.WriteLine(newString);



            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadLine();

        }

    }
}
