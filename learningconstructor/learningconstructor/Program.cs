using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningconstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmployee = new Employee("john","Doe", "");


            card mycards = new card ("A", "Heart", 10);
            Console.WriteLine(mycards.Val);
            Console.ReadLine();

        }


    }
}
