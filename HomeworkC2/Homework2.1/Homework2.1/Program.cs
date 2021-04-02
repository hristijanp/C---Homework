using System;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value.
            Console.WriteLine("======SwapNumbers======");

            int number1 = 0;
            int number2 = 0;

            Console.WriteLine("Enter your first number:");
            bool firstNumber = int.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter your second number:");
            bool secondNumber = int.TryParse(Console.ReadLine(), out number2);

            if(firstNumber && secondNumber)
            {
                Console.WriteLine("You have entered: " + number1 + number2);
                Console.WriteLine("If we swapped the numbers it would look like: " + number2 + number1);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
