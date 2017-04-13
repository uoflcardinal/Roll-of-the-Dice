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


            do
            {
                char yes;
                int numSides;

                Console.WriteLine("Enter the number of sides for a pair of dice:");
                // numSides = int.Parse(Console.ReadLine());
                numSides = GetValidInteger();
                Console.WriteLine("Welcome to the Grand Circus Casino!  Roll the dice? (y/n):");
                yes = char.Parse(Console.ReadLine());


                if (yes == 'y')
                {
                    Random rnd = new Random();

                    int dice = rnd.Next(1, numSides);
                    int dice2 = rnd.Next(1, numSides);

                    Console.WriteLine(dice);
                    Console.WriteLine(dice2);

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
    }
}
