using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandPrompt mycommand = new CommandPrompt(10, 15);
            mycommand.SetScreenText(2, "This line 2 text");
            mycommand.SetScreenText(1, "This line 1 text");
            mycommand.SetScreenText(4, "This line 4 text");
         //   mycommand.SetScreenText(11, "This line 11 text");
           
            mycommand.Display();
            Console.ReadLine();
        }
    }
}
