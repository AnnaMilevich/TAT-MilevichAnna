using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOUniversity
    {
        
        int universityID;
        
        string name;
      
        int addressID;
        public DBOUniversity(string name, int addressID, int universityID)
        {
            Name = name;
            AddressID = addressID;
            UniversityID = universityID;
        }
        public int UniversityID { get => universityID; set => universityID = value; }
        public string Name { get => name; set => name = value; }
        public int AddressID { get => addressID; set => addressID = value; }
    }
}
