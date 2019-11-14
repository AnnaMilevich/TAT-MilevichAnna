using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test2
{
    public class JSONProvider : IDBProvider
    {
        //University universities;
        JsonData jsonData;
            public JSONProvider(string fileName)
        {

            StreamReader r = new StreamReader(fileName);
            jsonData = JsonConvert.DeserializeObject<JsonData>(r.ReadToEnd());
           //universities = JsonConvert.DeserializeObject<University>(r.ReadToEnd());

        }
        public List<University> GetUniversities()
        { 
            List<University> universities= new List<University>();
            
            foreach(University university in  jsonData.universities)
            {
                List<Departament> departaments = new List<Departament>();
                foreach (Faculty faculty in university.FacultiesList)
                {
                    departaments.Add(faculty as Departament);
                }
  
                foreach (Service service in university.ServicesList)
                {               
                        departaments.Add(service as Departament);
                }
                foreach (Institute institute in university.InstitutesList)
                {
                        departaments.Add(institute as Departament);
                }
                foreach (Motorcade motorcade in university.MotorcadesList)
                {
                   
                        departaments.Add(motorcade as Departament);
                }
                universities.Add(new University(university.Name,
                     university.Address,
                     departaments));
            }
            return universities;
        }
        public List<Accountant> GetAccountants()
        {
            List<Accountant> accountants = new List<Accountant>();
            return accountants;
        }
 
        public List<Address> GetAddresses()
        {
            List<Address> addresses = new List<Address>();
            return addresses;
            //return jsonData.Addresses;
        }


        public List<Faculty> GetFaculties()
        {
            List<Faculty> faculties = new List<Faculty>();
            return faculties;
        }
        public List<DBOInstitute> GetDBOInstitutes()
        {
            List<DBOInstitute> dBOInstitutes = new List<DBOInstitute>();
            return dBOInstitutes;
            //return jsonData.DBOInstitutes;
        }

        public List<DBOService> GetDBOServices()
        {
            List<DBOService> dBOServices = new List<DBOService>();
            return dBOServices;
            //return jsonData.DBOServices;
        }

        public List<Dean> GetDeans()
        {
            List<Dean> deans = new List<Dean>();
            return deans;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            return employees;
        }

        public List<Head> GetHeads()
        {
            List<Head> heads = new List<Head>();
            return heads;
        }

        public List<Manager> GetManagers()
        {
            List<Manager> managers = new List<Manager>();
            return managers;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            return students;
        }
        public List<DBOAccountant> GetDBOAccountants()
        {
            List<DBOAccountant> dboAccountants = new List<DBOAccountant>();
            return dboAccountants;
        }
        public List<DBOFaculty> GetDBOFaculties()
        {
            List<DBOFaculty> dBOFaculties = new List<DBOFaculty>();
            return dBOFaculties;
        }
        public List<DBOAddress> GetDBOAddresses()
        {
            List<DBOAddress> dboAddresses = new List<DBOAddress>();
            return dboAddresses;
        }
        public List<DBOCar> GetDBOCars()
        {
            List<DBOCar> dboCars = new List<DBOCar>();
            return dboCars;
        }
        public List<DBOChief> GetDBOChiefs()
        {
            List<DBOChief> dboChiefs = new List<DBOChief>();
            return dboChiefs;
        }
        public List<DBODean> GetDBODeans()
        {
            List<DBODean> dboDeans = new List<DBODean>();
            return dboDeans;
        }
        public List<DBOEmployee> GetDBOEmployees()
        {
            List<DBOEmployee> dboEmployees = new List<DBOEmployee>();
            return dboEmployees;
        }
        public List<DBOGarage> GetDBOGarages()
        {
            List<DBOGarage> dboGarages = new List<DBOGarage>();
            return dboGarages;
        }
        public List<DBOHead> GetDBOHeads()
        {
            List<DBOHead> dboHeads = new List<DBOHead>();
            return dboHeads;
        }
        public List<DBOManager> GetDBOManagers()
        {
            List<DBOManager> dboManagers = new List<DBOManager>();
            return dboManagers;
        }
        public List<DBOMotorcade> GetDBOMotorcades()
        {
            List<DBOMotorcade> dboMotorcades = new List<DBOMotorcade>();
            return dboMotorcades;
        }
        public List<DBOStudent> GetDBOStudents()
        {
            List<DBOStudent> dboStudents = new List<DBOStudent>();
            return dboStudents;
        }
        public List<Institute> GetInstitutes()
        {
            List<Institute> institutes = new List<Institute>();
            return institutes;
        }
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            return services;
        }
        
        public List<Motorcade> GetMotorcades()
        {
            List<Motorcade> motorcades = new List<Motorcade>();
            return motorcades;
        }
    }
}