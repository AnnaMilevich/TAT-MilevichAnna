using System;


namespace DEV_7
{
    /// <summary>
    /// The class for Engine objects
    /// </summary>
    public class Engine
    {
        public double Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="power"></param>
        /// <param name="volume"></param>
        /// <param name="type"></param>
        /// <param name="serialNumber"></param>
        public Engine(double power, double volume, string type, string serialNumber)
        {
            Power = power >= 0 ? power : throw new Exception("Power of wheels cannot negative");
            Volume = volume >= 0 ? volume : throw new Exception("Volume of wheels cannot negative");
            Type = type != string.Empty ? type : throw new Exception("Type cannot be empty");
            SerialNumber = serialNumber != string.Empty ? serialNumber : throw new Exception("Serial number cannot be empty");
        }

        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public void GetEngineInformations()
        {
            Console.WriteLine("  Power : " + Power + "  Volume : " + Volume + "  Type : " + Type + " Serial number : " + SerialNumber);
        }
    }
}
