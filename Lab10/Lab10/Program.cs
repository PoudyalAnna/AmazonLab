using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{

       class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            DeckofCards myDeck = new DeckofCards();
            //cycle through deck
            foreach (Cards card in myDeck.Deck)
            {
                Console.WriteLine(card.ToString());
            }
            Console.ReadLine();


        }
    }
}
