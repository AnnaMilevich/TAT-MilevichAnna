using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_7
{
    /// <summary>
    /// The class for car park object
    /// </summary>
    public class CarPark
    {
        public List<Transport> TransportsList { get; set; }

        /// <summary>
        /// Constructor for the class initializes field
        /// </summary>
        /// <param name="transportsList"></param>
        public CarPark(List<Transport> transportsList)
        {
            TransportsList = transportsList;
        }

        /// <summary>
        /// This method adds transports to the list
        /// </summary>
        /// <param name="transport"></param>
        /// <returns></returns>
        public CarPark AddTransport(Transport transport)
        {
            if (!TransportsList.Contains(transport))
            {
                TransportsList.Add(transport);
            }
            return this;
        }

        /// <summary>
        /// This method returns information about all objects in the list
        /// </summary>
        public void GetTransportInformations()
        {
            double _engineVolume = 1.5;
            foreach (var transport in from transport in TransportsList
                                      where transport.Engine.Volume > _engineVolume
                                      select transport)
            {
                transport.GetInformations();
            }
        }

        /// <summary>
        /// This method returns information about Buses and Trucks
        /// </summary>
        public void GetInfoForBusAndTruck()
        {
            foreach (var transport in from transport in TransportsList
                                      where transport is Bus || transport is Truck
                                      select transport)
            {
                Console.WriteLine("  Power : " + transport.Engine.Power + "   Serial number : " + transport.Engine.SerialNumber);
            }
        }
    }
}

