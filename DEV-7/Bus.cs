using System;

namespace DEV_7
{
    /// <summary>
    /// The class for bus objects
    /// </summary>
    public class Bus : Transport
    {
        public int NumderOfPassegers { get; set; }
        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="transmission"></param>
        /// <param name="chassis"></param>
        /// <param name="engline"></param>
        /// <param name="numderOfPassegers"></param>
        public Bus(Transmission transmission,Chassis chassis, Engine engline ,int numderOfPassegers):base(transmission,chassis,engline) 
        {
            NumderOfPassegers= numderOfPassegers >= 0 ? numderOfPassegers : throw new Exception("Numder of passegers cannot negative");
        }
        /// <summary>
        /// This method returns bus information
        /// </summary>
        public override void GetInformations()
        {
            Console.WriteLine("Bus : ");
            base.GetInformations();
            Console.WriteLine("Numder of passegers : " + NumderOfPassegers);
        }
    }
}
