using System;

namespace DEV_7
{
    /// <summary>
    /// The class for Transport objects
    /// </summary>
    public class Transport 
    {
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }
        public Engine Engine { get; set; }

        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="transmission"></param>
        /// <param name="chassis"></param>
        /// <param name="engine"></param>
        public Transport(Transmission transmission, Chassis chassis,Engine engine)
        {
            Transmission = transmission;
            Chassis = chassis;
            Engine = engine;
        }

        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public virtual void GetInformations()
        {
            Console.WriteLine("Transmission : ");
            Transmission.GetTransmissionInformations();

            Console.WriteLine("Chassis : ");
            Chassis.GetChassisInformations();

            Console.WriteLine("Engine : ");
            Engine.GetEngineInformations();
        }
    }
}
