using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace test2
{
    public class Departament
    {
       
        string name;
        Address address;
 
        public Departament()
        {
        }

        public Departament(string name, Address address)
        {
            Name = name;
            Address = address;
        }
        [JsonProperty("name")]
        public string Name { get => name; set => name = value; }
        [JsonProperty("address")]
        public Address Address { get => address; set => address = value; }

        public override bool Equals(object obj)
        {
            return obj is Departament departament &&
                   name == departament.name &&
                   EqualityComparer<Address>.Default.Equals(address, departament.address);
        }

     

        public void Print()
        {
            Console.WriteLine(name + address);
        }
    
        public override string ToString()
        {
            return $"{name},{address.ToString()}";
        }
        public string GetDepartamentName()
        {
            return name;
        }
        
    }
}
