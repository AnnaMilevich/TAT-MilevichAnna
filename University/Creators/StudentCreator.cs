using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public static class StudentCreator
    {
        public static void SaveStudent()
        {
             
           
        }
        public static Student CreateFromConsole()
        {
            Student student = new Student();

            PersonCreator.CreateFromConsole("student", student);
            Console.WriteLine("Input Student faculty name");
            string facultyName = Console.ReadLine();
            Console.WriteLine("Input Student marks");
            student.MarksString = Console.ReadLine();
            return student;
        }

    }
}
