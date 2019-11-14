using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    [Serializable]
    public class JsonData
    {
        [JsonProperty("university")]
        public List<University> universities { get; set; }

        public JsonData(List<University> universitiesList)
        {
            universities = universitiesList;
        }
        //[JsonProperty("faculty")]
        //public List<Faculty> Faculties { get; set; }

        //[JsonProperty("institute")]
        //public List<Institute> Institutes { get; set; }

        //[JsonProperty("service")]
        //public List<Service> Services { get; set; }
        //[JsonProperty("motorcade")]
        //public List<Motorcade> Motorcades { get; set; }
        //[JsonProperty("dean")]
        //public Dean Dean { get; set; }

        //[JsonProperty("student")]
        //public List<Student> Students { get; set; }

        //[JsonProperty("manager")]
        //public Manager Manager { get; set; }

        //    [JsonProperty("employee")]
        //public List<Employee> Employees  { get; set; }

        //    [JsonProperty("head")]
        //public Head Heads { get; set; }

        //    [JsonProperty("accountant")]
        //public List<Accountant> Accountants  { get; set; }

        //    [JsonProperty("car")]
        //public Car Cars { get; set; }

        //    [JsonProperty("garage")]
        //public List<Garage> Garages { get; set; }

        //[JsonProperty("chief")]
        //public Chief Chief { get; set; }
        //[JsonProperty("address")]
        //public Address Address  { get; set; }
    }
    
}
