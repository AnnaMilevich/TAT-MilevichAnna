using System;


namespace DEV_7
{
    /// <summary>
    /// The class for Truck objects
    /// </summary>
    public class Truck : Transport
    {
        public double Weight { get; set; }

        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="transmission"></param>
        /// <param name="chassis"></param>
        /// <param name="engline"></param>
        /// <param name="weight"></param>
        public Truck(Transmission transmission, Chassis chassis, Engine engline, double weight) : base(transmission, chassis, engline)
        {
            Weight = weight >= 0 ? weight : throw new Exception("Weight cannot negative");
        }

        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public override void GetInformations()
        {
            Console.WriteLine("Truck : ");
            base.GetInformations();
            Console.WriteLine("Weight" + Weight);
        }
    }
}
