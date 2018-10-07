using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisection_Algorithm
{
    class HumanChoose
    {
        public static void Human()
        {
            Random rnd = new Random();
            int winningNumber = rnd.Next(1000);
            //int userInput = Program.aNumberBetween(1, 1000);
            int userInput;
            int count = 1;

            do
            {
                userInput = Number();

                if (userInput == winningNumber)
                {
                    Console.WriteLine($"Your number of {userInput} is correct.");
                    count++;
                }
                else if (userInput > winningNumber)
                {
                    Console.WriteLine($"Your number of {userInput} is to high.");
                    Console.WriteLine("Please try again.");
                    count++;                     
                }
                else
                {                    
                    Console.WriteLine($"Your number of {userInput} is to low.");
                    Console.WriteLine("Please try again.");
                    count++;
                }
                
            }
            while (userInput != winningNumber);            
            Console.WriteLine($"It took you {count} times to get the right number.");
            
        }
        private static int Number()
        {
            int userInput = 0;
            do
            {
                Console.WriteLine("\nPick a Number between 1 and 1000. ");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("You did not enter a valid number");
                }
            } while (userInput < 1 || userInput > 1000);
            return userInput;

        }
    }
}
