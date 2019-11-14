using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOHead:Person
    {

        
        int experience;
       
        int serviceID;
        
        int universityID;


        public DBOHead()
        {

        }
        public DBOHead(string firstname, string lastname, int yearOfBirth, int experience, int serviceID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            Experience = experience;
            ServiceID = serviceID;
            UniversityID = universityID;
        }

        public int Experience { get => experience; set => experience = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }

        public int GetServiceID()
        {
            return ServiceID;
        }
    }
}
