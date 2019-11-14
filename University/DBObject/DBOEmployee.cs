using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{ 
    public class DBOEmployee : Person
    {
        
        string position;
      
        int instituteID;
      
        int universityID;
        public DBOEmployee()
        {

        }
        public DBOEmployee(string firstname, string lastname, int yearOfBirth, string position, int instituteID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            Position = position;
            InstituteID = instituteID;
            UniversityID = universityID;
        }
        public string Position { get => position; set => position = value; }
        public int InstituteID { get => instituteID; set => instituteID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int GetInstituteID()
        {
            return instituteID;
        }
    }
}
