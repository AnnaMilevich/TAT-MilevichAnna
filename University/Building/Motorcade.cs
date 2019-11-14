using System.Collections.Generic;
using Newtonsoft.Json;
namespace test2
{
    public class Motorcade : Departament
    {

        List<Garage> garages = new List<Garage>();

        Chief chief;
        public Motorcade(string name, Address address, Chief chief, List<Garage> garages) : base(name, address)
        {
            Chief=chief;
            GaragesList = garages;
        }
        [JsonProperty("chief")]
        public Chief Chief{ get => chief; set => chief = value; }
        [JsonProperty("garage")]
        public List<Garage> GaragesList { get => garages; set => garages=value; }


    }
}
