
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test2
{
    [Serializable]
    public class Student : Person, IComparable
    {
        string marksString;

        List<int> marks = new List<int>();

        //[NonSerialized]
       
        private List<int> Marks { get
            {
                //foreach (String mark in new List<string>(marksString.Split(' ')))
                //{
                //    Marks.Add(Int32.Parse(mark));
                //}
                return marks;
            }
            set => marks = value; }
        [JsonProperty("marks")]
        public string MarksString { get => marksString; set => marksString = value;}

        public Student() { }
        public Student(string frstnm, string lstnm, int y, string marksString) : base(frstnm, lstnm, y)
        {
            if(marksString != null)
                Marks.AddRange(from String mark in new List<string>(marksString.Split(' '))
                               select Int32.Parse(mark));
            MarksString = marksString;
         
        }
     
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public double Averageball()
        {
            
            double averageball=0;
            foreach(int m in Marks)
            {
                averageball += m;
            }
            
  
            return averageball/Marks.Count;
        }
 
        public int CompareTo(object obj)
        {
            Student s = obj as Student;
            if (s != null)
                return this.Averageball().CompareTo(s.Averageball());
            else throw new Exception("error");

           }
    }
}

