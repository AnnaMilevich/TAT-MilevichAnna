using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test2
{
    public class DBOFaculty
    {
      
        string facutyName;
      
        int facultyID;
      
        int addressID;
        
        int universityID;

        public string FacutyName { get => facutyName; set => facutyName = value; }
        public int FacultyID { get => facultyID; set => facultyID = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }

        public DBOFaculty(string facultyName, int facultyID, int addressID, int universityID)
        {
            this.FacutyName = facultyName;
            this.FacultyID = facultyID;
            this.AddressID = addressID;
            UniversityID = universityID;
        }
     
        public string GetFacultyName()
        {
            return FacutyName;
        }
        public int GetAddressID()
        {
            return AddressID;
        }
        public int GetFacultyID()
        {
            return FacultyID;
        }

    }
}
