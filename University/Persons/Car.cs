using Newtonsoft.Json;
using System.Collections.Generic;


namespace test2
{
  public  class Car
    {
        
        string name;
        string platenumber;
        public Car(string name, string platenumber)
        {
            Name = name;
            Platenumber = platenumber;
        }
        [JsonProperty("name")]
        public string Name { get => name; set => name = value; }
        [JsonProperty("platenumber")]
        public string Platenumber { get => platenumber; set => platenumber = value; }
    }
}

