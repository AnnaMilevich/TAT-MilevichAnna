using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOGarage
    {
      
        int garagenumder;
       
        int garageID;
        
        int universityID;
        int motorcadeID;
       // int carID;

        public DBOGarage(int garagenumber, int garageID,int motorcadeID, int universityID)
        {
            Garagenumder = garagenumber;
            GarageID = garageID;
            UniversityID = universityID;
            MotorcadeID = motorcadeID;
           // CarID = carID;
        }

        public int Garagenumder { get => garagenumder; set => garagenumder = value; }
        public int GarageID { get => garageID; set => garageID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int MotorcadeID { get => motorcadeID; set => motorcadeID = value; }
       // public int CarID { get => carID; set => carID = value; }
        //public int GetMotorcadeID()
        //{
        //    return motorcadeID;
        //}
    }
}
