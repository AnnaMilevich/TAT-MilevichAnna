using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2 
{
    public class DBOStudent:Person
    {

       
        string marksString;
       
        List<int> marks = new List<int>();
       
        int facultyID;
       
        int universityID;
        public DBOStudent()
        {

        }
        public DBOStudent(string firstname, string lastname, int yearOfBirth, string marksString, int facultyID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            if (marksString != null)
                Marks.AddRange(from String mark in new List<string>(marksString.Split(' '))
                               select Int32.Parse(mark));
            //if (marks != null)
            //    Marks.AddRange(from String mark in marks
            //                   select Int32.Parse(mark));
            MarksString = marksString;
            FacultyID = facultyID;
            UniversityID = universityID;
        }
        public List<int> Marks
        {
            get
            {
                //foreach (String mark in new List<string>(marksString.Split(' ')))
                //foreach (String mark in new List<string>(marksString.Split(' ')))
                //{
                //    Marks.Add(Int32.Parse(mark));
                //}
                return marks;
            }
            set => marks = value;
        }
        public int FacultyID { get => facultyID; set => facultyID = value; }
        public string MarksString { get => marksString; set => marksString = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public int GetFacultyID()
        {
            return FacultyID;
        }
    }
}
