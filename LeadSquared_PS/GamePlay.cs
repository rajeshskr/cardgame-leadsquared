using LeadSquared_PS.Enums;
using LeadSquared_PS.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//User Game Play Class
namespace LeadSquared_PS
{
    class GamePlay
    {
        int choice;
        CardDeck deck;

        // Constructor - initializes the deck
        public GamePlay() {
            deck = new CardDeck();
        }


        // Let the Game Begin! It provides them with the below options to play the game
        public void start() {

                Console.WriteLine("Ding! Ding! Ding! Card Game Started !!");
                do
                {
                    Console.WriteLine("Please Choose one of the below Options to play: ");
                    Console.WriteLine("1. Play a Card");
                    Console.WriteLine("2. Shuffle the Deck");
                    Console.WriteLine("3. Restart the Game");
                    Console.WriteLine("4. Stop the Game");
                    Console.WriteLine("Sire, What do you suffice to do ?");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Cards card;
                            card = deck.playCard();
                            if (card != null)
                            {
                                Console.WriteLine("Sire, Card Withdrawn is: ");
                                Console.WriteLine($"Card Number:{card.CardNumber.ToString()} && Card Shape: {card.CardShape.ToString()}");
                            }
                            else
                            {
                                Console.WriteLine("No Cards Available! Kindly Restart the Game!! ");
                            }
                            break;
                        case 2:
                            deck.shuffleCards();
                            Console.WriteLine("Cards Shuffled !!");
                            break;
                        case 3:
                            deck = new CardDeck();
                            Console.WriteLine("Game Restarted !!");
                            break;
                        case 4:
                            Console.WriteLine("Game Stopped !!");
                            break;
                        default:
                            Console.WriteLine("Sire, Retry with below options!");
                            break;
                    }
                    Console.WriteLine("Press any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                } while (choice != 4);
            
        }
    }
}
