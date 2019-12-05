using System;

namespace DEV_6
{
    /// <summary>
    /// Class for creating a car 
    /// </summary>
    public static class CreatorCar
    {
        /// <summary>
        /// Method for creating a car using the console
        /// </summary>
        /// <returns></returns>
        public static Car CreatorFromConsole()
        {
            Car car = new Car();

            Console.WriteLine("Enter car brand");
            car.Brand = Console.ReadLine();

            Console.WriteLine("Enter car model");
            car.Model = Console.ReadLine();

            Console.WriteLine("Enter the number of cars");
            car.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the average price of cars");
            car.AveragePrice = double.Parse(Console.ReadLine());
            
            return car;
        }
    }
}
