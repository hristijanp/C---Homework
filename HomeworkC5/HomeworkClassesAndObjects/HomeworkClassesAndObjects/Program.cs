using System;

namespace HomeworkClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[4];
            Driver[] drivers = new Driver[4];
           
            #region Drivers
            
            Driver firstDriver = new Driver()
            {
                Name = "Bob",
                Skill = 80,
            };
            Driver secondDriver = new Driver()
            {
                Name = "Greg",
                Skill = 70,
            };
            Driver thirdDriver = new Driver()
            {
                Name = "Jill",
                Skill = 90,
            };
            Driver fourthDriver = new Driver()
            {
                Name = "Anne",
                Skill = 60,
            };
           
            #endregion
            
            #region Cars
            Car hyundai = new Car()
            {
                Model = "Hyundai Veloster N",
                Speed = 257,
            };
            Car mazda = new Car()
            {
                Model = "Mazda MX-5 Miata",
                Speed = 217,
            };
            Car ferrari = new Car()
            {
                Model = "Ferrari 812 Superfast",
                Speed = 339,
            };
            Car porsche = new Car()
            {
                Model = "Porsche 911 GT RS",
                Speed = 310,
            };
            
            #endregion
            
            drivers[0] = firstDriver;
            drivers[1] = secondDriver;
            drivers[2] = thirdDriver;
            drivers[3] = fourthDriver;

            cars[0] = hyundai;
            cars[1] = mazda;
            cars[2] = ferrari;
            cars[3] = porsche;
            
            #region FirsCarDriver
            
            Console.WriteLine("Select the first driver from the list:");
            for(byte i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            Console.WriteLine("Enter number of first car driver:");
            byte numberOfDriver = 0;
            bool driverNumber = byte.TryParse(Console.ReadLine(), out numberOfDriver);
            
            Console.WriteLine("========================");

            Console.WriteLine("Select a car for the first driver:");
            for(byte i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            Console.WriteLine("Enter number for a car of the first driver:");
            byte numberOfCar = 0;
            bool carNumber = byte.TryParse(Console.ReadLine(), out numberOfCar);

            Console.WriteLine("========================");

            #endregion

            #region secondCarDriver
            Console.WriteLine("Select the second driver from the list:");
            Console.WriteLine("Enter number of the second car driver:");
            for(byte i = 0; i < drivers.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");
            }
            byte numberOfDriver2 = 0;
            bool driverNumber2 = byte.TryParse(Console.ReadLine(), out numberOfDriver2);

            while(true)
            {
                if (numberOfDriver == numberOfDriver2)
                {
                    Console.WriteLine("The driver is racing already, select another driver:");
                    driverNumber2 = byte.TryParse(Console.ReadLine(), out numberOfDriver2);
                }
                else break;
            }

            Console.WriteLine("========================");

            Console.WriteLine("Select a car for the second driver:");
            for (byte i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
            Console.WriteLine("Enter number for a car of the first driver:");
            byte numberOfCar2 = 0;
            bool carNumber2 = byte.TryParse(Console.ReadLine(), out numberOfCar2);
            while(true)
            {
                if (numberOfCar == numberOfCar2)
                {
                    Console.WriteLine("That car is already racing, select another car:");
                    carNumber2 = byte.TryParse(Console.ReadLine(), out numberOfCar2);
                }
                else break;
            }

            #endregion

            numberOfDriver -= 1;
            numberOfCar -= 1;
            numberOfDriver2 -= 1;
            numberOfCar2 -= 1;

            if(carNumber && driverNumber && carNumber2 && driverNumber2 
                && (numberOfCar >= 0 || numberOfCar <= 3)
                && (numberOfDriver >= 0 || numberOfDriver <= 3)
                && (numberOfDriver2 >= 0 || numberOfDriver2 <= 3)
                && (numberOfCar2 >= 0 || numberOfCar2 <=3))
            {
                Car firstCar = cars[numberOfCar];
                Car secondCar = cars[numberOfCar2];

                firstCar.Driver = drivers[numberOfDriver];
                secondCar.Driver = drivers[numberOfDriver2];

                Car.RaceCars(firstCar, secondCar);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
            
        }
    }
}
