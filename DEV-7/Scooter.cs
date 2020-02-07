using System;

namespace DEV_7
{
    /// <summary>
    /// The class for Scooter objects
    /// </summary>
    public class Scooter : Transport
    {
        public string RightsCategory { get; set; }

        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="transmission"></param>
        /// <param name="chassis"></param>
        /// <param name="engline"></param>
        /// <param name="rightsCategory"></param>
        public Scooter(Transmission transmission, Chassis chassis, Engine engline, string rightsCategory) : base(transmission, chassis, engline)
        {
            RightsCategory=rightsCategory != string.Empty ? rightsCategory : throw new Exception("Rights category cannot be empty");
        }

        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public override void GetInformations()
        {
            Console.WriteLine("Scooter : ");
            base.GetInformations();
            Console.WriteLine("Rights category" + RightsCategory);
        }
    }
}
