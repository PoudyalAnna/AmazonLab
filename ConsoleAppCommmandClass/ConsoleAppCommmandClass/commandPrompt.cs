using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleAppCommmandClass
{
    class commandPrompt
    {

        //backgroung color
        //foreground color

        int height;
        int columns;
        string[] screenText;
        ConsoleColor backgroungcolor;
        ConsoleColor foregroundcolor;
        string filename;

        //constructor
        public commandPrompt(int height, int columns)
        {
            // set the default backgroundcolor
            backgroungcolor = ConsoleColor.Yellow;
            foregroundcolor = ConsoleColor.Red;

            //   Console.BackgroundColor = ConsoleColor.Red;
            //  Console.ForegroundColor = ConsoleColor.Black;
            //set the default foregroundcolor
            // create screen to hold the rowa height

            screenText = new string[height];

            Console.SetWindowSize(columns, height + 7);

            //let set the screen text to empty
            for (int i = 0; i < screenText.Length; i++)
            {

                screenText[i] = " ";
            }

        }
        public void SetScreenText(int lineNumber, string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }   // end of SetScreenText method
        public void Display()
        {
            //set the foregroundcolor and background color

            Console.BackgroundColor = backgroungcolor;
            Console.ForegroundColor = foregroundcolor;

            Console.Clear();
           // Console.WriteLine("THis is test-----------------");
            // ptint the screen text array test

            for (int i = 0; i < screenText.Length; i++)
            {

                Console.WriteLine(screenText[i]);
            }

        }
        public void SetBackgroundColor(string color)
        {

            backgroungcolor = ConvertColor(color);
        }
        public void SetForegroundColor(string color)
        {

            foregroundcolor = ConvertColor(color);
        }
        public static ConsoleColor ConvertColor(String strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black; break;
                case "red": color = ConsoleColor.Red; break;
                case "blue": color = ConsoleColor.Blue; break;
                default: color = ConsoleColor.DarkGray; break;
            }
            return color;

        }




        public void SaveScreen(string fileName)
        {
            FileStream stream;
            StreamWriter textOut = null;
            try
            {
                fileName = "C:/Project/AmazonLab/ConsoleAppCommmandClass/ConsoleAppCommmandClass/"  +  fileName;
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(stream);
               
                for (int i = 0; i < screenText.Length ; i++)
                {
                    textOut.WriteLine(screenText[i]);
                }
                textOut.WriteLine("Yes it work");
                textOut.WriteLine("Yes it work45");

                //your code here!!!
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }   // of of SaveScreen method
        public void ReloadScreen(string fileName) {
            FileStream stream;
            filename = "C:/Project/AmazonLab/ConsoleAppCommmandClass/ConsoleAppCommmandClass/" + filename;
          stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            using (StreamReader textIn = new StreamReader(stream))
            {

                // step3

                Console.WriteLine(textIn.ReadToEnd());

            }
        }

       
                 

    }
}