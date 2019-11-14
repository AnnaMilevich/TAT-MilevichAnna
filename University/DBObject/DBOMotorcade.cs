using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
   public class DBOMotorcade
    {

        string motorcadeName;
     
        int motorcadeID;
       
        int addressID;
        
        int universityID;

        public DBOMotorcade(string name, int motorcadeID, int addressID, int universityID)
        {
            MotorcadeName = name;
            MotorcadeID = motorcadeID;
            AddressID = addressID;
            UniversityID = universityID;

        }
        public string MotorcadeName { get => motorcadeName; set => motorcadeName = value; }
        public int MotorcadeID { get => motorcadeID; set => motorcadeID = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }

    }
}
