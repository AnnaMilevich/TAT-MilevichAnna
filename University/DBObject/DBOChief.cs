using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOChief:Person
    {
     
       
        int motorcadeID;
       
        int universityID;
        public DBOChief()
        {

        }
        public DBOChief(string firstname, string lastname, int yearOfBirth, int motorcadeID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            MotorcadeID = motorcadeID;
            UniversityID = universityID;
        }
        public int MotorcadeID { get => motorcadeID; set => motorcadeID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int GetMotorcadeID()
        {
            return motorcadeID;
        }
    }
}
