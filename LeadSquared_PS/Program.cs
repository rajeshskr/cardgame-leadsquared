using LeadSquared_PS.Enums;
using LeadSquared_PS.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Main Method to create the Game Play class and kick of the game
namespace LeadSquared_PS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GamePlay game = new GamePlay();
                game.start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message Log:");
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}
