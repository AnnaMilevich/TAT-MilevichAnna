using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOManager:Person
    {
       
        int roomnumber;
       
        int instituteID;
       
        int universityID;

        public DBOManager()
        {

        }
        public DBOManager(string firstname, string lastname, int yearOfBirth, int roomnumber, int instituteID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            Roomnumber = roomnumber;
            InstituteID = instituteID;
            UniversityID = universityID;
        }

        public int Roomnumber { get => roomnumber; set => roomnumber = value; }
        public int InstituteID { get => instituteID; set => instituteID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int GetInstituteID()
        {
            return InstituteID;
        }

    }
}
