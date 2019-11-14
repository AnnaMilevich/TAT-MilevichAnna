using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class StudentComparerFistName : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.GetFirstName().CompareTo(s2.GetFirstName());

        }
    }
    
}
