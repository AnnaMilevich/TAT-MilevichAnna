using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBODean : Person
    {
       
        string degree;
       
        int facultyID;
       
        int universityID;
        public DBODean()
        {

        }
         public DBODean(string firstname, string lastname, int yearOfBirth, string degree, int facultyID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            Degree=degree;
            FacultyID = facultyID;
            UniversityID = universityID;
        }
        public string Degree { get => degree; set => degree = value; }
        public int FacultyID { get => facultyID; set => facultyID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int GetFacultyID()
        {
            return facultyID;
        }
    }
}
