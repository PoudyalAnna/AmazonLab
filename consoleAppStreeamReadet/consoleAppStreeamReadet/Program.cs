using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace consoleAppStreeamReadet
{
    class Program
    {
        static void Main(string[] args)
        {

          //  Stream mystream;
         //   mystream = null;
         //step 1

            
            FileStream myfile = new FileStream("textfile1.txt", FileMode.Open, FileAccess.Read);

            //step2
            StreamReader myFilereader = new StreamReader(stream: myfile);

            // step3

            Console.WriteLine(myFilereader.ReadToEnd());
            Console.ReadLine();
                 
        }
    }
}
