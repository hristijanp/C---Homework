using System;

namespace Homework2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======TikTakTik - Tak======");

            int number = 0;

            Console.WriteLine("Enter a number that is divisible by 3, 5 or 3 and 5 and it will return Tik - Tak's");
            bool tik = int.TryParse(Console.ReadLine(), out number);

            if(tik)
            {
                if(number % 3 == 0)
                {
                    Console.Write("Tik");
                    if(number % 5 == 0 )
                    {
                        Console.Write(" - Tak");
                    }
                }
                else if(number % 5 == 0)
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("You have entered a number that is not devisible by 3 or 5");
                }    
                    
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
