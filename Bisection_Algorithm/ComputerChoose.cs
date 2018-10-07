using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    class ComputerChoose
    {
        public static void Computer()
        {
            int winner = Number();
            int count = 1;
            int min = 0;
            int max = 100;
            int computerInput;
            int userInput;

            do
            {
                computerInput = Guess(min, max);
                Console.WriteLine($"Computer guesses {computerInput}.");
                Console.WriteLine("Make a selection.");
                Console.WriteLine("1. High\n2. Low\n3. Guess is correct");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 3)
                {
                    Console.WriteLine("\nDING\n");
                }
                else if (userInput == 1)
                {
                    max = computerInput;
                    count++;
                }
                else
                {
                    min = computerInput;
                    count++;
                }
            }
            while (computerInput != winner);
            Console.WriteLine($"The Computer selected the winning number in {count} attempts.");
        }
        private static int Number()
        {
            int win = 0;
            do
            {
                Console.WriteLine("Please enter the number the computer needs to guess.");
                Console.WriteLine("Keep the number between 1 and 100");
                try
                {
                    win = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (win < 1 || win > 100);
            return win;
        }
        private static int Guess(int min, int max)
        {
            int choice = min + ((max - min) / 2);
            return choice;
        }
    }
}
