using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class AllDBOObject
    {
        List<DBOFaculty> dboFaculties = new List<DBOFaculty>();
        List<DBODean> dboDeans = new List<DBODean>();
        List<DBOStudent> dboStudents = new List<DBOStudent>();
        List<DBOAddress> dboAddresses = new List<DBOAddress>();
        List<DBOService> dboServices = new List<DBOService>();
        List<DBOHead> dboHeads = new List<DBOHead>();
        List<DBOAccountant> dboAccountants = new List<DBOAccountant>();
        List<DBOInstitute> dboInstitutes = new List<DBOInstitute>();
        List<DBOManager> dboManagers = new List<DBOManager>();
        List<DBOEmployee> dboEmployees = new List<DBOEmployee>();
        List<DBOMotorcade> dboMotorcades = new List<DBOMotorcade>();
        List<DBOChief> dboChiefs = new List<DBOChief>();
        List<DBOGarage> dboGarages = new List<DBOGarage>();
        List<DBOCar> dboCars = new List<DBOCar>();
        List<DBOUniversity> dboUniversities = new List<DBOUniversity>();
        public AllDBOObject(List<DBOFaculty> dboFaculties, List<DBODean> dboDeans, List<DBOStudent> dboStudents,
             List<DBOAddress> dboAddresses, List<DBOService> dboServices, List<DBOHead> dboHeads,
             List<DBOAccountant> dboAccountants, List<DBOInstitute> dboInstitutes, List<DBOManager> dboManagers,
              List<DBOEmployee> dboEmployees, List<DBOMotorcade> dboMotorcades, List<DBOChief> dboChiefs, List<DBOGarage> dboGarages,
               List<DBOCar> dboCars, List<DBOUniversity> dboUniversities)
        {
            DBOFaculties = dboFaculties;
            DBODeans = dboDeans;
            DBOStudents = dboStudents;
            DBOAddresses = dboAddresses;
            DBOServices = dboServices;
            DBOHeads = dboHeads;
            DBOAccountants = dboAccountants;
            DBOInstitutes = dboInstitutes;
            DBOManagers = dboManagers;
            DBOEmployees = dboEmployees;
            DBOMotorcades = dboMotorcades;
            DBOChiefs = dboChiefs;
            DBOGarages = dboGarages;
            DBOCars = dboCars;
            DBOUniversities = dboUniversities;

        }
        public List<DBOAccountant> DBOAccountants { get => dboAccountants; set => dboAccountants = value; }
        public List<DBOAddress> DBOAddresses { get => dboAddresses; set => dboAddresses = value; }
        public List<DBOCar> DBOCars { get => dboCars; set => dboCars = value; }
        public List<DBOChief> DBOChiefs { get => dboChiefs; set => dboChiefs = value; }
        public List<DBODean> DBODeans { get => dboDeans; set => dboDeans = value; }
        public List<DBOEmployee> DBOEmployees { get => dboEmployees; set => dboEmployees = value; }
        public List<DBOFaculty> DBOFaculties { get => dboFaculties; set => dboFaculties = value; }
        public List<DBOGarage> DBOGarages { get => dboGarages; set => dboGarages = value; }
        public List<DBOHead> DBOHeads { get => dboHeads; set => dboHeads = value; }
        public List<DBOInstitute> DBOInstitutes { get => dboInstitutes; set => dboInstitutes = value; }
        public List<DBOManager> DBOManagers { get => dboManagers; set => dboManagers = value; }
        public List<DBOMotorcade> DBOMotorcades { get => dboMotorcades; set => dboMotorcades = value; }
        public List<DBOService> DBOServices { get => dboServices; set => dboServices = value; }
        public List<DBOStudent> DBOStudents { get => dboStudents; set => dboStudents = value; }
        public List<DBOUniversity> DBOUniversities { get => dboUniversities; set => dboUniversities = value; }

    }
}
