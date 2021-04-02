using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
            Console.WriteLine("======AverageNumber======");

            double number1 = 0;
            double number2 = 0;
            double number3 = 0;
            double number4 = 0;

            Console.WriteLine("Enter your first number:");
            bool firstNumber = double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Enter your second number:");
            bool secondNumber = double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Enter your third number:");
            bool thirdNumber = double.TryParse(Console.ReadLine(), out number3);
            Console.WriteLine("Enter your fourth number:");
            bool fourttNumber = double.TryParse(Console.ReadLine(), out number4);

            if(firstNumber && secondNumber && thirdNumber && fourttNumber)
            {
                Console.WriteLine((number1 + number2 + number3 + number4) / 4 + " is the average of your four numbers.");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
