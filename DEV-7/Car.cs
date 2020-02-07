using System;

namespace DEV_7
{
    /// <summary>
    /// The class for Car objects
    /// </summary>
    public class Car : Transport
    {
        public string Color { get; set; }
        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="transmission"></param>
        /// <param name="chassis"></param>
        /// <param name="engline"></param>
        /// <param name="color"></param>
        public Car(Transmission transmission, Chassis chassis, Engine engline, string color) : base(transmission, chassis, engline)
        {
            Color = color != string.Empty ? color  : throw new Exception("Color cannot be empty");
        }
        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public override void GetInformations()
        {
            Console.WriteLine("Car : ");
            base.GetInformations();
            Console.WriteLine("Color : " + Color);
        }
    }
}
