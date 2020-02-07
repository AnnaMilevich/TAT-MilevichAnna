using System;


namespace DEV_7
{
    /// <summary>
    /// The class for Chassis objects
    /// </summary>
    public class Chassis
    {
        public int NumberOfWheels { get; set; }
        public string Number { get; set; }
        public double PermissibleLoad { get; set; }

        /// <summary>
        /// Constructor for the class initializes fields
        /// </summary>
        /// <param name="numberOfWheels"></param>
        /// <param name="number"></param>
        /// <param name="permissibleLoad"></param>
        public Chassis(int numberOfWheels,string number, double permissibleLoad)
        {
            NumberOfWheels = numberOfWheels >= 0 ? numberOfWheels : throw new Exception("Number of wheels cannot negative");
            Number = number != string.Empty ? number : throw new Exception("Numder cannot be empty");
            PermissibleLoad = permissibleLoad >= 0 ? permissibleLoad : throw new Exception("Permissible load of wheels cannot negative");
        }
        /// <summary>
        /// This method returns information about an object
        /// </summary>
        public void GetChassisInformations()
        {
            Console.WriteLine("  Number of wheels : " + NumberOfWheels + "  Number : " + Number + "  Permissible load : " + PermissibleLoad);
        }
    }
}
