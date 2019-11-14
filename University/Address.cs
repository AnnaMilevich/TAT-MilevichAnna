using Newtonsoft.Json;
using System;


namespace test2
{
    public class Address
    {
        //[JsonProperty("city")]
        String city;
       // [JsonProperty("street")]
        String street;
       // [JsonProperty("building")]
        int building;
        //[JsonProperty("addressID")]
        //int addressID;
        public Address()
        {

        }
        public Address( String ct, String strt, int bldng)
        {
            City = ct;
            Street = strt;
            Building = bldng;
            //this.AddressID = addressID;

        }
        [JsonProperty("city")]
        public string City { get => city; set => city = value; }
        [JsonProperty("street")]
        public string Street { get => street; set => street = value; }
        [JsonProperty("building")]
        public int Building { get => building; set => building = value; }
       // public int AddressID { get => addressID; set => addressID = value; }

       
        public void Print()
        {
            Console.WriteLine(City + Street + Building);
        }
        //public override bool Equals(object obj)
        //{
        //    Departament dpt = obj as Departament ;
        //    Address ad =dpt.departamentAdress;

        //    return (street == ad?.street) && (city== ad?.city) && (building == ad?.building);
        //}
        public override string ToString()
        {
            return $"{City},{Street},{Building}";
        }
    }
}
