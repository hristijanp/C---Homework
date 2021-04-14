using System;

namespace HomeworkC5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DateTime");
            Console.WriteLine("=========================");

            // Print the current date with time
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate);
            Console.WriteLine("=========================");

            // Print the date that is 10 years from now
            DateTime addyears = DateTime.Now.AddYears(10);
            Console.WriteLine(addyears);
            Console.WriteLine("=========================");

            // Print the date that is 2 months and 15 days ago
            DateTime removeDate = DateTime.Now.AddMonths(-2).AddDays(-15);
            Console.WriteLine(removeDate);
            Console.WriteLine("=========================");

            // Print day of week for the next 8-th March
            string dateFormat1 = ($"8th of March next year is on {new DateTime(DateTime.Today.Year + 1, 3, 8).ToString("dddd")}");
            Console.WriteLine(dateFormat1);
            Console.WriteLine("=========================");

            // Print day of week of last year's Valentine's day
            string dateFormat2 = ($"14th February, Valentine's day last year was on {new DateTime(DateTime.Today.Year - 1, 2, 14).ToString("dddd")}");
            Console.WriteLine(dateFormat2);
            Console.WriteLine("=========================");

            Console.ReadLine();
        }
    }
}
