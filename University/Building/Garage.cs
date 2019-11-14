using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace test2
{
   public class Garage
    {
       
        int garagenumder;
        Car car;
        public Garage(int grgnmb, Car car)
        {
            Garagenumder = grgnmb;
            Car = car;
        }
        [JsonProperty("number")]
        public int Garagenumder { get => garagenumder; set => garagenumder = value; }
        [JsonProperty("car")]
        public Car Car { get => car; set => car = value; }
    }
}
