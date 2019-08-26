using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class DeckofCards
    {
        
        public List<Cards> Deck { get; set; }          
        
        private const int NUMBER_OF_CARDS = 52;

        public DeckofCards(List<Cards> deck)
        {
            Deck = deck;
        }

        public DeckofCards()
        {
            string[] face = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10","J","Q","K" };
            string[] suits = { "♠", "♥", "♣", "♦ " };
            int[] value = { 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            //new deck
            Deck = new List<Cards>();

            // populatie entries deck array with Cord objects;
            for (int count = 0; count < NUMBER_OF_CARDS; count++)
            {
                Deck.Add(new Cards(face[count % 13], suits[count / 13], value[count
                    % 13]));
            }
        }
    }
}
