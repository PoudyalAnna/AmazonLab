using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            // veriable decleration

            double dblHeitht;
            double dblWeight;
            double BMI;

            Console.WriteLine("Pls Enter Your Height  in inches: ");
            dblHeitht = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pls Enter Your Weight in Pound: ");
            dblWeight = Convert.ToInt32(Console.ReadLine());


            //calculate

            BMI = (dblWeight * 703) / (dblHeitht * dblHeitht);

            Console.WriteLine("Your BMI is: " + BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("BMI  < 18.5 - Underweight");
            }
            else if (BMI <= 24.9)
            {
                Console.WriteLine("BMI  btn  18.5  and 24.8 -Normal");
            }
            else if (BMI <= 29.9)
            {
                Console.WriteLine("BMI  btn 24 and 29 - overweight");
            }
            else
            {
                Console.WriteLine("BMI  >=  30 obses");
            }
            Console.ReadLine();

            //ho to change

            // need to change


        }
    }
}
