using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public interface IDBProvider
    {
        List<University> GetUniversities();
        List<DBOAccountant> GetDBOAccountants();
        List<DBOAddress> GetDBOAddresses();
        List<DBOCar> GetDBOCars();
        List<DBOChief> GetDBOChiefs();
        List<DBODean> GetDBODeans();
        List<DBOEmployee> GetDBOEmployees();
        List<DBOFaculty> GetDBOFaculties();
        List<DBOGarage> GetDBOGarages();
        List<DBOHead> GetDBOHeads();
        List<DBOInstitute> GetDBOInstitutes();
        List<DBOManager> GetDBOManagers();
        List<DBOMotorcade> GetDBOMotorcades();
        List<DBOService> GetDBOServices();
        List<DBOStudent> GetDBOStudents();
        List<Institute> GetInstitutes();
        List<Service> GetServices();
        List<Faculty> GetFaculties();
        List<Motorcade> GetMotorcades();

       // List<Student> GetStudents();
       // List<Dean> GetDeans();

       // List<Employee> GetEmployees();

        //List<Head> GetHeads();
        //List<Address> GetAddresses();
        //List<Accountant> GetAccountants();
        //List<Manager> GetManagers();
    }
}
