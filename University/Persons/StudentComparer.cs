using System.Collections.Generic;

namespace test2
{
    class StudentComparer: IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            return s1.GetLastName().CompareTo(s2.GetLastName());
                
        }
    }
}
