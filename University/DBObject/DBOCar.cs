using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
     public class DBOCar
    {
        
        string name;
        
        string platenumber;
        int garageID;
        
        int universityID;
        int motorcadeID;
      //  int carID;

        public DBOCar()
        {

        }
        public DBOCar(string name, string platenumber, int garageID,int motorcadeID, int universityID)
        {
            Name = name;
            Platenumber = platenumber;
            GarageID = garageID;
            UniversityID = universityID;
            MotorcadeID = motorcadeID;
           // CarID = carID;
        }
        public string Name { get => name; set => name = value; }
        public string Platenumber { get => platenumber; set => platenumber = value; }
        public int GarageID { get => garageID; set => garageID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int MotorcadeID { get => motorcadeID; set => motorcadeID = value; }
       // public int CarID { get => carID; set => carID = value; }
    }
}
