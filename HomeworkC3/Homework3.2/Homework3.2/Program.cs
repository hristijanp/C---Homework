using System;

namespace Homework3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            // Get a number from the console between 1 and 2 and print the students from that group in the console
            Console.WriteLine("======StudentGroup======");

            string[] studentsG1 = new string[]
            {
                "Goran",
                "Zoran",
                "Rade",
                "Marija",
                "Nikolina"
            };

            string[] studentsG2 = new string[]
            {
                "Blagica",
                "Zorica",
                "Vasko",
                "Miki",
                "Ivana"
            };

            Console.WriteLine("Enter 1 to see the students in G1, enter 2 to see the students in G2");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("The students in G1 are: ");
                        foreach (string item in studentsG1) 
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "2":
                    Console.WriteLine("The students in G2 are: ");
                        foreach(string item2 in studentsG2)
                    {
                        Console.WriteLine(item2);
                    }
                    break;
                default:
                    Console.WriteLine("You have to enter 1 or 2");
                    break;
            }

            Console.ReadLine();
   }    }   
}
