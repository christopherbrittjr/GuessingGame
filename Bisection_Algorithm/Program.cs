using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bisection_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please make a selection.");
            Console.WriteLine("1. Bisection\n2. Human's Choose\n3. Computer Choose");
            int pick = Convert.ToInt32(Console.ReadLine());

            if (pick == 1)
            {
                FirstOne();
            }
            else if (pick == 2)
            {
                HumanChoose.Human();
            }
            else if (pick == 3)
            {
                ComputerChoose.Computer();
            }           
            
        }

        static int FirstOne()
        {
            int[] list = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int userInput = aNumberBetween(1, 10);            
            int max;
            int min = 0;
            int middle;
            bool outOfLoop = false;

            
            Console.WriteLine($"The User has given the number {userInput}.");
            Console.WriteLine("The range of numbers is from 1 to 10 using spots 0 through 9 in the array.");
            Console.WriteLine("The computer checks the mid point of the array.\n");

            max = list.Length - 1;

            do
            {
                middle = min + ((max - min) / 2);

                if (userInput < list[middle])
                {
                    Console.WriteLine($"We check the middle element which is {middle}.\n");
                    Console.WriteLine($"Your number {userInput} is lower than list[{middle}] which is {list[middle]}.\n");
                    max = middle - 1;
                    Console.WriteLine($"We changed the max number to {middle} minus 1.\n");
                }
                else if (userInput > list[middle])
                {
                    Console.WriteLine($"We check the middle element which is {middle}.\n");
                    Console.WriteLine($"Your number {userInput} is higher than list[{middle}] which is {list[middle]}.\n");
                    min = middle + 1;
                    Console.WriteLine($"We changed the min number is {middle} plus 1.\n");
                }
                else
                {
                    Console.WriteLine($"Your number {userInput} is the correct number");
                    outOfLoop = true;
                }
                Console.ReadLine();
            }            
            while (!outOfLoop);
            return middle;
        } 

        public static int aNumberBetween(int low, int high)
        {
            bool inBounds = false;
            int input = 0;
            do
            {
                try
                {
                    Console.WriteLine($"Please choose a number between {low} and {high}.");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input >= low && input <= high)
                    {
                        inBounds = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }                
            }
            
            while (!inBounds);

            return input; 
        }

    }
}
