using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClassesAndObjects
{
    public class Car
    {
        public Car() { }
        public string Model { get; set; }
        public Driver Driver { get; set; }
        public short Speed { get; set; }

        public int CalculateSpeed ()
        {
            return this.Driver.Skill + this.Speed;
        }

        static public void RaceCars(Car firstCar, Car secondCar)
        {
            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed()) Console.WriteLine($"{firstCar.Driver.Name} wins while driving the {firstCar.Model}");
            else if (firstCar.CalculateSpeed() < secondCar.CalculateSpeed()) Console.WriteLine($"{secondCar.Driver.Name} wins while driving the {secondCar.Model}");
            else Console.WriteLine("It's a tie between the two drivers");
        }
    }
}
