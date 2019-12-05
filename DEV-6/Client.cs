using System;

namespace DEV_6
{
    /// <summary>
    /// Class gives info about cars from catalog to the client
    /// </summary>
    public class Client
    {
        private ICommand Command { get; set; }
        private Catalog Catalog { get; set; }
        /// <summary>
        /// Constructor initializes fields
        /// </summary>
        /// <param name="catalog"></param>
        public Client(Catalog catalog) => Catalog = catalog;
        /// <summary>
        /// Method displays info according to chosen command
        /// </summary>
        public void GetInformation()
        {
            Console.WriteLine( "Commands :\n1)count types\n2)count all\n3)average price\n4)average price <type>\n5)exit");
            Console.WriteLine( "Enter command : ");
            string command = String.Empty;
            while ((command = Console.ReadLine().ToLower()) != "exit")
            {
                if (command == "count all")
                {
                    Command = new CountAllCommand(Catalog);
                    Console.WriteLine(Command.Execute());
                }
                else if (command == "count types")
                {
                    Command = new CountTypesCommand(Catalog);
                    Console.WriteLine(Command.Execute());
                }
                else if (command == "average price")
                {
                    Command = new AveragePriceCommand(Catalog);
                    Console.WriteLine(Command.Execute());
                }
                else if (command.Contains("average price"))
                {
                    bool isBrandOnTheCatalog = false;
                    foreach (Car car in Catalog.Cars)
                    {
                        if (command.Contains(car.Brand.ToLower()))
                        {
                            Command = new AveragePriceByBrandCommand(Catalog, car.Brand);
                            Console.WriteLine(Command.Execute());
                            isBrandOnTheCatalog = true;
                            break;
                        }
                    }
                    if (!isBrandOnTheCatalog)
                    {
                        Console.WriteLine("We dont have cars of this brand.");
                    }
                }
                else
                {
                    Console.WriteLine("This command does not exist. Please enter from the suggested list.");
                }
            }
        }
    }
}
