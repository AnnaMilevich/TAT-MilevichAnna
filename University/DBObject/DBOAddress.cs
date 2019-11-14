using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOAddress
    {
       
        String city;
        
        String street;
        
        int building;
        
        int addressID;
       
        int universityID;
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int Building { get => building; set => building = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public DBOAddress()
        {

        }
        public DBOAddress(int addressID, String city, String street, int building, int universityID)
        {
            City = city;
            Street = street;
            Building = building;
            AddressID = addressID;
            UniversityID = universityID;
        }
        public int GetAddressID()
        {
            return AddressID;
        }

    }
}





























