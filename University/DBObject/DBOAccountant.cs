using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test2
{
    public class DBOAccountant:Person
    {
        
        int salary;
        
        int serviceID;
        
        int universityID;
        public int Salary { get => salary; set => salary = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }
        public DBOAccountant(string firstname, string lastname, int yearOfBirth, int salary, int serviceID, int universityID) : base(firstname, lastname, yearOfBirth)
        {
            Salary = salary;
            ServiceID = serviceID;
            UniversityID = universityID;
        }

        public DBOAccountant()
        {

        }
        public int GetServiceID()
        {
            return serviceID;
        }
    }
}
