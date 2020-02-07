using System.Collections.Generic;

namespace DEV_7
{
    /// <summary>
    /// Entry point of the program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Transport> transports = new List<Transport>();
            transports.Add(new Truck(new Transmission("gerg", 16, "ggdgg"), new Chassis(443, "eefw", 43), new Engine(545, 1.5, "rge", "grg"), 4000));
            transports.Add(new Car(new Transmission("gerg", 16, "ggdgg"), new Chassis(443, "eefw", 43), new Engine(545, 1.6, "rge", "grg"), "fsg"));
            transports.Add(new Bus(new Transmission("gerg", 16, "ggdgg"), new Chassis(443, "eefw", 43), new Engine(545, 545, "rge", "grg"), 40));
            CarPark carPark = new CarPark(transports);
            carPark.GetTransportInformations();

        }
    }
}
