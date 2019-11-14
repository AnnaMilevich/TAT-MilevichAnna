using Newtonsoft.Json;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;


namespace test2
{
    [Serializable]
    public class Dean : Person
    {
       
        string degree;
      
        public Dean()
        {

        }
        public Dean(string frstnm, string lstnm, int y, string dgr) : base(frstnm, lstnm, y)
        {
            Degree = dgr;
        }
        [JsonProperty("degree")]

        public string Degree { get => degree; set => degree = value; }
        //public int FacultyID { get => facultyID; set => facultyID = value; }

        //public int GetFacultyID()
        //{
        //    return FacultyID;
        //}
        public override string ToString()
        {
            return base.ToString() + ", degree: " + $"{Degree}";
        }
    }
}
