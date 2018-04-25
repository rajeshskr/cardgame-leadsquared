using LeadSquared_PS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Card Deck Class Definitions and Methods

namespace LeadSquared_PS.Objects
{
    class CardDeck
    {
        private Cards[] cards;
        int i;
        private const int TOTAL_CARDS=52, TOTAL_CARD_NUMBERS=13, TOTAL_CARD_SHAPES=4;

        //Constructor - Creates set of 52 cards and shuffles them
        public CardDeck()
        {
            try
            {
                i = TOTAL_CARDS - 1;
                cards = new Cards[TOTAL_CARDS];
                int x = 0;
                for (int a = 0; a <= TOTAL_CARD_SHAPES - 1; a++)
                {
                    for (int b = 0; b <= TOTAL_CARD_NUMBERS - 1; b++)
                    {
                        cards[x] = new Cards((CardShapes)a, (CardNumbers)b);
                        x++;
                    }
                }
                this.shuffleCards();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
        }

        //Shuffle the availble card
        public void shuffleCards() {
            try
            {
                Random rnd = new Random();
                int index = 0;
                for (int j = 0; j <= i; j++)
                {
                    index = rnd.Next(i - j);
                    Cards temp = cards[index];
                    cards[index] = cards[i];
                    cards[i] = temp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
        }


        //Play a card from the deck
        public Cards playCard()
        {
            Cards temp = null;
            try
            {
                
                if (i >= 0)
                {
                    temp = cards[i];
                    cards[i] = null;
                    i--;
                }
                else temp = null;
            } 
            
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
            return temp;

        }
    }
}
