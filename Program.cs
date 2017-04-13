using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Delcaring variables.
            int dice;
            int dice2;
            char yes;
            int numSides;

            //Do-while loop to process the game.
            do
            {
              
                Console.WriteLine("Enter the number of sides for a pair of dice:");
                // numSides = int.Parse(Console.ReadLine());
                numSides = GetValidInteger();
                Console.WriteLine("Welcome to the Grand Circus Casino!  Roll the dice? (y/n):");
                //yes = char.Parse(Console.ReadLine());
                yes = GetValidChar();

                if (yes == 'y')
                {
                    Random rnd = new Random();

                     dice = rnd.Next(1, numSides);
                     dice2 = rnd.Next(1, numSides);

                    Console.WriteLine(dice);
                    Console.WriteLine(dice2);

                        if (dice == 1 && dice2 == 1)
                    {
                        Console.WriteLine("You got snake eyes!" );
                    }
                        else if (dice == 6 && dice2 == 6)
                    {
                        Console.WriteLine("You got box cars!");
                    }
                        else if (dice + dice2 == 7 || dice + dice2 == 11)
                    {
                        Console.WriteLine("You got craps!");
                    }

                    Console.WriteLine("Thanks for playing!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    return;
                }

            } while (true);

        }




        public static int GetValidInteger()
        {
            int input;
           

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("The input is not a number! Please enter a number! ");
            }
            return input;
        }

        public static char GetValidChar()
        {
            char Letter;

            while (!char.TryParse(Console.ReadLine(), out Letter))
            {
                Console.WriteLine("The input is not 'y' or 'n'!");
            }
            return Letter;
        }
    }
}
