using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace test2
{
    public class XMLProvider : IDBProvider

    {
        string filename;
        XDocument XmlDocument;

        public XMLProvider(string filename)
        {
            XmlDocument = XDocument.Load(filename);

        }
        public List<DBOUniversity> GetDBOUniversity()
        {
            return (from XElement dboUniversityElement in XmlDocument.Element("root").Element("universities").Elements("university")
                    select new DBOUniversity(dboUniversityElement.Attribute("name").Value,
                    Int32.Parse(dboUniversityElement.Element("addressID").Value),
                    Int32.Parse(dboUniversityElement.Element("universityID").Value))).ToList();
        }
        public List<DBOUniversity> GetDBOUniversities()
        {
            return (from XElement dboUniversityElement in XmlDocument.Element("root").Element("universities").Elements("university")
                    select new DBOUniversity(dboUniversityElement.Attribute("name").Value,
                    Int32.Parse(dboUniversityElement.Element("addressID").Value),
                    Int32.Parse(dboUniversityElement.Element("universityID").Value))).ToList();


        }

        public List<DBOAddress> GetDBOAddresses()
        {
            return (from XElement dboAddressElement in XmlDocument.Element("root").Element("addresses").Elements("address")
                    select new DBOAddress(Int32.Parse(dboAddressElement.Attribute("addressID").Value),
                    dboAddressElement.Element("city").Value,
                    dboAddressElement.Element("street").Value,
                    Int32.Parse(dboAddressElement.Element("building").Value),
                    Int32.Parse(dboAddressElement.Element("universityID").Value))).ToList();
        }
        public List<DBOAccountant> GetDBOAccountants()
        {
            return (from XElement dboAccountantElement in XmlDocument.Element("root").Element("accountants").Elements("accountant")
                    select new DBOAccountant(
                    dboAccountantElement.Attribute("firstname").Value,
                    dboAccountantElement.Attribute("lastname").Value,
                    Int32.Parse(dboAccountantElement.Element("yearOfBirth").Value),
                    Int32.Parse(dboAccountantElement.Element("salary").Value),
                    Int32.Parse(dboAccountantElement.Element("serviceID").Value),
                    Int32.Parse(dboAccountantElement.Element("universityID").Value))).ToList();
        }
        public List<DBOCar> GetDBOCars()
        {
            return (from XElement dboCarElement in XmlDocument.Element("root").Element("cars").Elements("car")
                    select new DBOCar(
                        dboCarElement.Attribute("name").Value,
                        dboCarElement.Element("platenumber").Value,
                        Int32.Parse(dboCarElement.Element("garageID").Value),
                        Int32.Parse(dboCarElement.Element("motorcadeID").Value),
                        Int32.Parse(dboCarElement.Element("universityID").Value))).ToList();
        }
        
        public List<DBOChief> GetDBOChiefs()
        {
            return (from XElement dboChiefElement in XmlDocument.Element("root").Element("chiefs").Elements("chief")
                    select new DBOChief(dboChiefElement.Attribute("firstname").Value,
                    dboChiefElement.Attribute("lastname").Value,
                    Int32.Parse(dboChiefElement.Element("yearOfBirth").Value),
                    Int32.Parse(dboChiefElement.Element("motorcadeID").Value),
                    Int32.Parse(dboChiefElement.Element("universityID").Value))).ToList();
        }
        public List<DBODean> GetDBODeans()
        {
            return (from XElement dboDeanElement in XmlDocument.Element("root").Element("deans").Elements("dean")
                    select new DBODean(dboDeanElement.Attribute("firstname").Value,
                    dboDeanElement.Attribute("lastname").Value,
                    Int32.Parse(dboDeanElement.Element("yearOfBirth").Value),
                    dboDeanElement.Element("degree").Value,
                    Int32.Parse(dboDeanElement.Element("facultyID").Value),
                    Int32.Parse(dboDeanElement.Element("universityID").Value))).ToList();
        }
        public List<DBOEmployee> GetDBOEmployees()
        {
            return (from XElement dboEmployeeElement in XmlDocument.Element("root").Element("employees").Elements("employee")
                    select new DBOEmployee(
                    dboEmployeeElement.Attribute("firstname").Value,
                    dboEmployeeElement.Attribute("lastname").Value,
                    Int32.Parse(dboEmployeeElement.Element("yearOfBirth").Value),
                    dboEmployeeElement.Element("position").Value,
                    Int32.Parse(dboEmployeeElement.Element("instituteID").Value),
                    Int32.Parse(dboEmployeeElement.Element("universityID").Value))).ToList();
        }
        public List<DBOFaculty> GetDBOFaculties()
        {
            return (from XElement dboFacultyElement in XmlDocument.Element("root").Element("faculties").Elements("faculty")
                    select new DBOFaculty(dboFacultyElement.Attribute("name").Value,
                    Int32.Parse(dboFacultyElement.Element("facultyID").Value),
                    Int32.Parse(dboFacultyElement.Element("addressID").Value),
                    Int32.Parse(dboFacultyElement.Element("universityID").Value))).ToList();
        }
        public List<DBOGarage> GetDBOGarages()
        {
            return (from XElement dboGarageElement in XmlDocument.Element("root").Element("garages").Elements("garage")
                    select new DBOGarage(Int32.Parse(dboGarageElement.Attribute("number").Value),
                    Int32.Parse(dboGarageElement.Element("garageID").Value),
                    Int32.Parse(dboGarageElement.Element("motorcadeID").Value),
                    Int32.Parse(dboGarageElement.Element("universityID").Value))).ToList();
                        
        }
        public List<DBOHead> GetDBOHeads()
        {
            return (from XElement dboHeadElement in XmlDocument.Element("root").Element("heads").Elements("head")
                    select new DBOHead(dboHeadElement.Attribute("firstname").Value,
                    dboHeadElement.Attribute("lastname").Value,
                    Int32.Parse(dboHeadElement.Element("yearOfBirth").Value),
                    Int32.Parse(dboHeadElement.Element("experience").Value),
                    Int32.Parse(dboHeadElement.Element("serviceID").Value),
                    Int32.Parse(dboHeadElement.Element("universityID").Value))).ToList();
        }
        public List<DBOInstitute> GetDBOInstitutes()
        {
            return (from XElement dboinstituteElement in XmlDocument.Element("root").Element("institutes").Elements("institute")
                    select new DBOInstitute(dboinstituteElement.Attribute("name").Value,
                    Int32.Parse(dboinstituteElement.Element("instituteID").Value),
                    Int32.Parse(dboinstituteElement.Element("addressID").Value),
                    Int32.Parse(dboinstituteElement.Element("universityID").Value))).ToList();
        }
        public List<DBOManager> GetDBOManagers()
        {
            return (from XElement dboManagerElement in XmlDocument.Element("root").Element("managers").Elements("manager")
                    select new DBOManager(dboManagerElement.Attribute("firstname").Value,
                    dboManagerElement.Attribute("lastname").Value,
                    Int32.Parse(dboManagerElement.Element("yearOfBirth").Value),
                    Int32.Parse(dboManagerElement.Element("roomnumber").Value),
                    Int32.Parse(dboManagerElement.Element("instituteID").Value),
                    Int32.Parse(dboManagerElement.Element("universityID").Value))).ToList();
        }
        public List<DBOMotorcade> GetDBOMotorcades()
        {
            return (from XElement dboMotorcadeElement in XmlDocument.Element("root").Element("motorcades").Elements("motorcade")
                    select new DBOMotorcade(dboMotorcadeElement.Attribute("name").Value,
                    Int32.Parse(dboMotorcadeElement.Element("motorcadeID").Value),
                    Int32.Parse(dboMotorcadeElement.Element("addressID").Value),
                    Int32.Parse(dboMotorcadeElement.Element("universityID").Value))).ToList();
        }
        public List<DBOService> GetDBOServices()
        {
            return (from XElement dboserviceElement in XmlDocument.Element("root").Element("services").Elements("service")
                    select new DBOService(dboserviceElement.Attribute("name").Value,
                    Int32.Parse(dboserviceElement.Element("serviceID").Value),
                    Int32.Parse(dboserviceElement.Element("addressID").Value),
                    Int32.Parse(dboserviceElement.Element("universityID").Value))).ToList();
        }
        public List<DBOStudent> GetDBOStudents()
        {
            return (from XElement dboStudentElement in XmlDocument.Element("root").Element("students").Elements("student")
                    select new DBOStudent(
                    dboStudentElement.Attribute("firstname").Value,
                    dboStudentElement.Attribute("lastname").Value,
                    Int32.Parse(dboStudentElement.Element("yearOfBirth").Value),
                    dboStudentElement.Element("marks").Value,
                    Int32.Parse(dboStudentElement.Element("facultyID").Value),
                    Int32.Parse(dboStudentElement.Element("universityID").Value))).ToList();
        }
        public List<Departament> GetDepartamentsByUniversityID(int universityID)
        {
            List<Departament> departaments = new List<Departament>();
            List<DBOFaculty> dboFaculties = GetDBOFaculties();
            List<Faculty> faculties = GetFaculties();
            foreach (var dboFaculty in from DBOFaculty dboFaculty in dboFaculties
                                       where dboFaculty.UniversityID.Equals(universityID)
                                       select dboFaculty)
            {
                foreach (Faculty faculty in faculties)
                {
                    if (dboFaculty.FacutyName == faculty.Name && faculty is Departament)

                        departaments.Add(faculty as Departament);
                   
                }
            }
            List<DBOService> dboServices = GetDBOServices();
            List<Service> services= GetServices();
            foreach (var dboService in from DBOService dboService in dboServices
                                       where dboService.UniversityID.Equals(universityID)
                                       select dboService)
            {
                foreach (Service service in services)
                {
                    if (dboService.ServiceName == service.Name)
                        departaments.Add(service as Departament);
                    
                }
            }
            List<DBOInstitute> dboInstitutes = GetDBOInstitutes();
            List<Institute> institutes = GetInstitutes();
            foreach (var dboInstitute in from DBOInstitute dboInstitute in dboInstitutes
                                         where dboInstitute.UniversityID.Equals(universityID)
                                       select dboInstitute)
            {
                foreach (Institute institute in institutes)
                {
                    if (dboInstitute.InstituteName == institute.Name)
                        departaments.Add(institute as Departament);
                    
                }
            }
            List<DBOMotorcade> dboMotorcades = GetDBOMotorcades();
            List<Motorcade> motorcades = GetMotorcades();
            foreach (var dboMotorcade in from DBOMotorcade dboMotorcade in dboMotorcades
                                         where dboMotorcade.UniversityID.Equals(universityID)
                                       select dboMotorcade)
            {
                foreach (Motorcade motorcade in motorcades)
                {
                    if (dboMotorcade.MotorcadeName == motorcade.Name)
                        departaments.Add(motorcade as Departament);
                    break;
                }
            }

            return departaments;
        }

        public List<University> GetUniversities()
        {
           
            List<University> universities = new List<University>();
            List<DBOUniversity> dboUniversities = GetDBOUniversities();
            universities.AddRange(from DBOUniversity dboUniversity in dboUniversities
                                  select new University(dboUniversity.Name,
                                  GetAddressByAddressID(dboUniversity.AddressID),
                                  GetDepartamentsByUniversityID(dboUniversity.UniversityID)));
            return universities;
        }

        public List<Accountant> GetAccountants()
        {
            List<Accountant> accountants = new List<Accountant>();
            List<DBOAccountant> dboAccountants = GetDBOAccountants();
            accountants.AddRange(from DBOAccountant dboAccountant in dboAccountants
                                 select new Accountant(dboAccountant.Firstname,
                                                        dboAccountant.Lastname,
                                                        dboAccountant.YearOfBirth,
                                                        dboAccountant.Salary));
            return accountants;

        }
        public List<Faculty> GetFaculties()
        {
            List<DBOFaculty> bdoFaculties = GetDBOFaculties();
            return (from DBOFaculty dboFaculty in bdoFaculties
                    select new Faculty(dboFaculty.GetFacultyName(),
                    GetAddressByAddressID(dboFaculty.GetAddressID()),
                    GetDeanByFacultyID(dboFaculty.GetFacultyID()),
                    GetStudentsByFacultyID(dboFaculty.GetFacultyID()))).ToList();
        }
        public List<Motorcade> GetMotorcades()
        {
            List<DBOMotorcade> dboMotorcades = GetDBOMotorcades();
            return (from DBOMotorcade dboMotorcade in dboMotorcades
                    select new Motorcade(dboMotorcade.MotorcadeName,
                    GetAddressByAddressID(dboMotorcade.AddressID),
                    GetChiefByMotorcadeID(dboMotorcade.MotorcadeID),
                    GetGaragesByMotorcadeID(dboMotorcade.MotorcadeID))).ToList();
        }
        
        private Chief GetChiefByMotorcadeID(int motorcadeID)
        {
            Chief chief = null;
            foreach (var c in from DBOChief c in GetDBOChiefs()
                              where c.GetMotorcadeID().Equals(motorcadeID)
                              select c)
            {
                chief = new Chief(c.Firstname,
                    c.Lastname,
                    c.YearOfBirth);
                break;
            }
            return chief;

        }
      
        private Dean GetDeanByFacultyID(int facultyID)
        {
            Dean dean = null;
            foreach (var d in from DBODean d in GetDBODeans()
                              where d.GetFacultyID().Equals(facultyID)
                              select d)
            {
                dean = new Dean(d.Firstname,
                    d.Lastname,
                    d.YearOfBirth,
                    d.Degree);
                break;
            }
            return dean;
        }
        private Address GetAddressByAddressID(int addressID)
        {
            Address address = null;
            foreach (var a in from DBOAddress a in GetDBOAddresses()
                              where a.GetAddressID().Equals(addressID)
                              select a)
            {
                address = new Address(a.City,
                    a.Street,
                    a.Building);
                break;
            }
            return address;
        }
        public List<Garage> GetGaragesByMotorcadeID(int motorcadeID)
        {
            List<Garage> garages = new List<Garage>();
            List<DBOGarage> dboGarages = GetDBOGarages();
            garages.AddRange(from DBOGarage dboGarag in dboGarages
                             where motorcadeID.Equals(dboGarag.MotorcadeID)
                             select new Garage(dboGarag.Garagenumder,
                            GetCarByGarageID(dboGarag.GarageID)));

            return garages;
        }
        private Car GetCarByGarageID(int garageID)
        {
            Car car = null;
            List<DBOCar> dboCars = GetDBOCars();
            foreach (var c in from DBOCar c in dboCars
                              where c.GarageID.Equals(garageID)
                              select c)
            {
                car = new Car(c.Name,
                    c.Platenumber);
                break;
            }
            return car;
        }
        public List<Student> GetStudentsByFacultyID(int facultyID)
        {
            List<Student> studentsFaculty = new List<Student>();
            List<DBOStudent> dbostudents = GetDBOStudents();
            studentsFaculty.AddRange(from DBOStudent s in dbostudents
                                     where facultyID.Equals(s.GetFacultyID())
                                     select new Student(s.Firstname,
                                     s.Lastname,
                                     s.YearOfBirth,
                                     s.MarksString));

            return studentsFaculty;
        }
        public List<Institute> GetInstitutes()
        {
            List<DBOInstitute> dboinstitutes = GetDBOInstitutes();
            return (from DBOInstitute dboinstitute in dboinstitutes
                    select new Institute(dboinstitute.GetInstituteName(),
                    GetAddressByAddressID(dboinstitute.GetAddressID()),
                    GetManagerByInstituteID(dboinstitute.GetInstituteID()),
                    GetEmployeesByInstituteID(dboinstitute.GetInstituteID()))).ToList();
        }
        private Manager GetManagerByInstituteID(int instituteID)
        {
            Manager manager = null;
            foreach (var m in from DBOManager m in GetDBOManagers()
                              where m.GetInstituteID().Equals(instituteID)
                              select manager = new Manager(m.Firstname,
                              m.Lastname,
                              m.YearOfBirth,
                              m.Roomnumber))
            {
                break;
            }

            return manager;
        }
        public List<Employee> GetEmployeesByInstituteID(int instituteID)
        {
            List<Employee> employeesInstitute = new List<Employee>();
            List<DBOEmployee> dboEmployees = GetDBOEmployees();
            employeesInstitute.AddRange(from DBOEmployee e in dboEmployees
                                        where instituteID.Equals(e.GetInstituteID())
                                        select new Employee(e.Firstname,
                                        e.Lastname,
                                        e.YearOfBirth,
                                        e.Position));
            return employeesInstitute;
        }
        public List<Service> GetServices()
        {
            List<DBOService> dboservices = GetDBOServices();
            return (from DBOService dboservise in dboservices
                    select new Service(dboservise.GetServiceName(),
                    GetAddressByAddressID(dboservise.GetAddressID()),
                    GetHeadByServiceID(dboservise.GetServiceID()),
                    GetAccountantsByServiceID(dboservise.GetServiceID()))).ToList();
        }
        private Head GetHeadByServiceID(int serviceID)
        {
            Head head = null;
            foreach (var h in from DBOHead h in GetDBOHeads()
                              where h.GetServiceID().Equals(serviceID)
                              select head = new Head(h.Firstname,
                              h.Lastname,
                              h.YearOfBirth,
                              h.Experience))
            {
                break;
            }

            return head;
        }
        public List<Accountant> GetAccountantsByServiceID(int serviceID)
        {
            List<Accountant> accountantsService = new List<Accountant>();
            List<DBOAccountant> dboAccountants = GetDBOAccountants();
            accountantsService.AddRange(from DBOAccountant a in dboAccountants
                                        where serviceID.Equals(a.GetServiceID())
                                        select new Accountant(a.Firstname,
                                        a.Lastname,
                                        a.YearOfBirth,
                                        a.Salary));
            return accountantsService;
        }
       
        //public List<Accountant> GetAccountants()
        //{
        //    List<DBOAccountant> dboAccountants.GetDBOAccountants();

        //    //foreach ()
        //        return (from XElement accountantElement in XmlDocument.Element("bsu").Element("accountants").Elements("accountant")
        //                select new Accountant(
        //                accountantElement.Attribute("firstname").Value,
        //                accountantElement.Attribute("lastname").Value,
        //                Int32.Parse(accountantElement.Element("yearofbirth").Value),
        //                Int32.Parse(accountantElement.Element("salary").Value),
        //                Int32.Parse(accountantElement.Element("serviceID").Value))).ToList();
        //}

        //public List<Address> GetAddresses()
        //{
        //    return (from XElement addressElement in XmlDocument.Element("bsu").Element("addresses").Elements("address")
        //            select new Address(Int32.Parse(addressElement.Attribute("addressID").Value),
        //            addressElement.Element("city").Value,
        //            addressElement.Element("street").Value,
        //            Int32.Parse(addressElement.Element("building").Value))).ToList();
        //}
        //public List<Student> GetStudents()
        //{
        //    return (from XElement studentElement in XmlDocument.Element("root").Element("students").Elements("student")
        //            select new Student(
        //            studentElement.Attribute("firstname").Value,
        //            studentElement.Attribute("lastname").Value,
        //            Int32.Parse(studentElement.Element("yearofbirth").Value),
        //            studentElement.Element("marks").Value,
        //            Int32.Parse(studentElement.Element("facultyID").Value))).ToList();
        //}

        //public List<Dean> GetDekans()
        //{
        //    return (from XElement dekanElement in XmlDocument.Element("bsu").Element("dekans").Elements("dekan")
        //            select new Dean(dekanElement.Attribute("firstname").Value,
        //            dekanElement.Attribute("lastname").Value,
        //            Int32.Parse(dekanElement.Element("yearofbirth").Value),
        //            dekanElement.Element("degree").Value,
        //            Int32.Parse(dekanElement.Element("facultyID").Value))).ToList();
        //}

        //public List<Employee> GetEmployees()
        //{
        //    return (from XElement employeeElement in XmlDocument.Element("bsu").Element("employees").Elements("employee")
        //            select new Employee(
        //            employeeElement.Attribute("firstname").Value,
        //            employeeElement.Attribute("lastname").Value,
        //            Int32.Parse(employeeElement.Element("yearofbirth").Value),
        //            employeeElement.Element("position").Value,
        //            Int32.Parse(employeeElement.Element("instituteID").Value))).ToList();
        //}
        //public List<Manager> GetManagers()
        //{
        //    return (from XElement managerElement in XmlDocument.Element("bsu").Element("managers").Elements("manager")
        //            select new Manager(managerElement.Attribute("firstname").Value,
        //            managerElement.Attribute("lastname").Value,
        //            Int32.Parse(managerElement.Element("yearofbirth").Value),
        //            Int32.Parse(managerElement.Element("roomnumber").Value),
        //            Int32.Parse(managerElement.Element("instituteID").Value))).ToList();
        //}

        //public List<Head> GetHeads()
        //{
        //    return (from XElement headElement in XmlDocument.Element("bsu").Element("heads").Elements("head")
        //            select new Head(headElement.Attribute("firstname").Value,
        //            headElement.Attribute("lastname").Value,
        //            Int32.Parse(headElement.Element("yearofbirth").Value),
        //            Int32.Parse(headElement.Element("experience").Value),
        //            Int32.Parse(headElement.Element("serviceID").Value))).ToList();
        //}

        //public void GetElement()
        //{
        //    XElement root = new XElement("students");
        //    XElement.Add(new XElement("student"));
        //    root.Add(new XElement("SnippetCode", "SnippetCode"));
        //    doc.Element("Snippets").Add(root);
        //    doc.Save(spath);

        //}

        //public void SerializationStudentInJson()
        //{
        //    XmlSerializer formatter = new XmlSerializer(typeof(Student));
        //    using (FileStream fs = new FileStream(XmlDocument.Element("bsu").Element("students").Elements("student"))//, FileMode.Append))
        //    {
        //        formatter.Serialize(fs, student);

        //        Console.WriteLine("Объект сериализован");
        //    }
        //foreach (XElement studentElement in XmlDocument.Element("bsu").Element("students").Elements("student"))
        //{
        //    new Head(headElement.Attribute("firstname").Value,
        //    headElement.Attribute("lastname").Value,
        //    Int32.Parse(headElement.Element("yearofbirth").Value),
        //    Int32.Parse(headElement.Element("experience").Value),
        //    Int32.Parse(headElement.Element("serviceID").Value))).ToList();
        //}


    }
}
