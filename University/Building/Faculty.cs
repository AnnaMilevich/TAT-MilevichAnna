using System.Collections.Generic;
using Newtonsoft.Json;
namespace test2
{
    public class Faculty : Departament
    {
     
        Dean dean;
        public delegate void StudentAdd(string message);
        public event StudentAdd StudentAdded;

        List<Student> studentsList = new List<Student>();
        public Faculty(string nm, Address dA, Dean dean, List<Student> students) : base(nm, dA)
        {
            Dean = dean;
            StudentsList = students;
        }
        [JsonProperty("student")]
        public List<Student> StudentsList { get => studentsList; set => studentsList = value; }
        [JsonProperty("dean")]
        public Dean Dean { get => dean; set => dean = value; }
       

        public Faculty AddStudent(Student X)//, string facultyName)//, CreatorUniversity managerUniversity)
        {
            if (!StudentsList.Contains(X) && StudentsList.Count < 1000)
            {

                StudentsList.Add(X);
                StudentAdded.Invoke($"Add student, " + $" facultyName: {Name}");
            }
            return this;
        }

        public override bool Equals(object obj)
        {
            return obj is Faculty faculty &&
                   base.Equals(obj) &&
                   EqualityComparer<Dean>.Default.Equals(dean, faculty.dean) &&
                   EqualityComparer<List<Student>>.Default.Equals(studentsList, faculty.studentsList);
        }

        

        public override string ToString()
        {
            return base.ToString() + ", Dean: " + $"{dean.ToString()}";
        }
       

    }
}

