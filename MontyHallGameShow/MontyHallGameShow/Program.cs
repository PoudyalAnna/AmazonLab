using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontyHallGameShow
{
    class Program
    {
        static void Main(string[] args)
        {
            //local veriable
            Random myrandom = new Random();
            bool[] doors;
            int nSwapped = 0, nStayed = 0;
            int nPlyer = 0;
            int nEleminated = 0;
            bool didSwalps;

            // itetate out mintyHall routing
            for (int i = 0; i < 10000; i++)
            {
                doors = new bool[] { false, false, false };

                // Initial car placement and player pic
                doors[myrandom.Next(0, 2)] = true;
                nPlyer = i % 3;
                didSwalps = false;

                // find door to eliminate

                for (int j = 0; j < doors.Length; j++)
                {
                    if (!doors[j] && j != nPlyer)
                    {
                        nEleminated = j;
                        break;
                    }

                }
                //player swaps on even
                if (i % 2 == 0)
                {
                    // find other door to switch
                    for (int k = 0; k < doors.Length; k++)
                    {
                        if (k != nEleminated && k != nPlyer)
                            nPlyer = k;
                        break;
                    }
                }
                didSwalps = true;
           
        
            // see if player won or lost
            if(doors[nPlyer] && didSwalps)
            {
                nStayed++;

            }
            else if(doors[nPlyer] && !didSwalps)
            {
                nStayed++;
            }
        }
            Console.WriteLine("The Player won {0} times when swapping and {1} time" +
                "when not swappint out of 10,000 turns", nSwapped, nStayed);
            Console.ReadLine();


        }


    }
}
