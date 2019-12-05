using System;
using System.Collections.Generic;

namespace DEV_6
{
    /// <summary>
    /// Entry point to the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Car> cars = new List<Car>();
                Catalog catalog = new Catalog(cars);
                catalog.AddCar(CreatorCar.CreatorFromConsole());
                Client client = new Client(catalog);
                client.GetInformation();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
