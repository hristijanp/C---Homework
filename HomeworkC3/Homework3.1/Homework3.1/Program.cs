using System;

namespace Homework3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:
            Console.WriteLine("======sumOfEven======");

            int[] integer = new int[6];
            int sum = 0;

            Console.WriteLine("Enter 6 numbers and I will return the sum of the even numbers");
            for(int i = 0; i < integer.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                bool number = int.TryParse(Console.ReadLine(), out integer[i]);
                if(number)
                {
                    if (integer[i] % 2 == 0) sum += integer[i];
                    else continue;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            Console.WriteLine("The sum of the even numbers is: " + sum);


            Console.ReadLine();
        }
    }
}
