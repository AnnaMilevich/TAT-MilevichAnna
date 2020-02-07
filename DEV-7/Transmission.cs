using System;

namespace DEV_7
{
    /// <summary>
    /// The class for Transmission objects
    /// </summary>
    public class Transmission
    {
        public string Type { get; set; }
        public int CountOfGears { get; set; }
        public string Manufacturer { get; set; }

        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="type"></param>
        /// <param name="countOfGears"></param>
        /// <param name="manufacturer"></param>
        public Transmission(string type, int countOfGears, string manufacturer)
        {
            Type = type != string.Empty ? type : throw new Exception("Type cannot be empty");
            CountOfGears = countOfGears >= 0 ? countOfGears : throw new Exception("Count of gears of wheels cannot negative");
            Manufacturer = manufacturer != string.Empty ? manufacturer : throw new Exception("Manufacturer cannot be empty");
        }

        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public void GetTransmissionInformations()
        {
            Console.WriteLine("  Type : " + Type + "  Count of gears : " + CountOfGears + "  Manufacturer : " + Manufacturer);
        }
    
    }
}
