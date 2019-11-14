using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace test2
{
    public class CreatorUniversity
    {
        IDBProvider provider;
        
        public CreatorUniversity(IDBProvider prvdr)
        {
            provider = prvdr;
        }
        public List<University> Universities()
        {

            List<University> universities = provider.GetUniversities();
          
            //Student student1 = new Student("fdfпsdvddf", "fsfvdvff", 1999, "7 9 5 4", 2);
            //faculties[student1.GetFacultyID() - 1].AddStudent(student1, faculties[student1.GetFacultyID() - 1].GetDepartamentName());
            return universities;
        }
        public List<AllDBOObject> GetAllDBOObjects(List<University> universities)
        {
            List<AllDBOObject> allDBOObjects = new List<AllDBOObject>();
            List<DBOUniversity> dboUniversities = new List<DBOUniversity>();
            foreach (University university in universities)
            {
                int count = 1;
                List < Faculty > faculties = university.GetFacultyOfDepartaments(university.GetDepartamentsList());
                List<DBOFaculty> dboFaculties = new List<DBOFaculty>();
                List<DBODean> dboDeans = new List<DBODean>();
                List<DBOStudent> dboStudents = new List<DBOStudent>();
                List<DBOAddress> dboAddresses = new List<DBOAddress>();
                int countFaculty = 1;
                foreach (Faculty faculty in faculties)
                {
                   
                    dboFaculties.Add(new DBOFaculty(faculty.Name,
                         countFaculty,
                         dboAddresses.Count(),
                         count));
                    dboDeans.Add(new DBODean(faculty.Dean.Firstname,
                        faculty.Dean.Lastname,
                        faculty.Dean.YearOfBirth,
                        faculty.Dean.Degree,
                        countFaculty,
                         count));
                    dboAddresses.Add(new DBOAddress(dboAddresses.Count(),
                        faculty.Address.City,
                        faculty.Address.Street,
                        faculty.Address.Building,
                        count));
                    List<Student> students = new List<Student>();
                    students = faculty.StudentsList;
                    foreach (Student student in students)
                    {
                        dboStudents.Add(new DBOStudent(student.Firstname,
                            student.Lastname,
                            student.YearOfBirth,
                            student.MarksString,
                            dboFaculties.Count(),
                            count)); 
                    }
                    countFaculty++;
                }
                List<Service> services = university.GetServiceOfDepartaments(university.GetDepartamentsList());
                List<DBOService> dboServices = new List<DBOService>();
                List<DBOHead> dboHeads = new List<DBOHead>();
                List<DBOAccountant> dboAccountants = new List<DBOAccountant>();
                    int countService = 1;
                foreach (Service servic in services)
                {
                    
                        dboServices.Add(new DBOService(servic.Name,
                            countService,
                             dboAddresses.Count(),
                             count));
                        dboHeads.Add(new DBOHead(servic.Head.Firstname,
                            servic.Head.Lastname,
                            servic.Head.YearOfBirth,
                            servic.Head.Experience,
                            countService,
                             count));
                        dboAddresses.Add(new DBOAddress(dboAddresses.Count(),
                            servic.Address.City,
                            servic.Address.Street,
                            servic.Address.Building,
                            count));
                        List<Accountant> accountants = new List<Accountant>();
                        accountants = servic.AccountantsList;
                        foreach (Accountant accountant in accountants)
                        {
                            dboAccountants.Add(new DBOAccountant(accountant.Firstname,
                                accountant.Lastname,
                                accountant.YearOfBirth,
                                accountant.Salary,
                                dboAccountants.Count(),
                                count));
                        }
                    countService++;


                }
                List<Institute> institutes = university.GetInstituteOfDepartaments(university.GetDepartamentsList());
                List<DBOInstitute> dboInstitutes = new List<DBOInstitute>();
                List<DBOManager> dboManagers = new List<DBOManager>();
                List<DBOEmployee> dboEmployees = new List<DBOEmployee>();
                int countInstitute = 1;
                foreach (Institute institute in institutes)
                {
                    dboInstitutes.Add(new DBOInstitute(institute.Name,
                        countInstitute,
                         dboAddresses.Count(),
                         count));
                    dboManagers.Add(new DBOManager(institute.Manager.Firstname,
                        institute.Manager.Lastname,
                        institute.Manager.YearOfBirth,
                        institute.Manager.Roomnumber,
                        countInstitute,
                         count));
                    dboAddresses.Add(new DBOAddress(dboAddresses.Count(),
                        institute.Address.City,
                        institute.Address.Street,
                        institute.Address.Building,
                        count));
                    List<Employee> employees = new List<Employee>();
                    employees = institute.EmployeesList;
                    foreach (Employee employee in employees)
                    {
                        dboEmployees.Add(new DBOEmployee(employee.Firstname,
                            employee.Lastname,
                            employee.YearOfBirth,
                            employee.Position,
                            dboEmployees.Count(),
                            count));
                    }
                    countInstitute++;
                }
                List<Motorcade> motorcades = university.GetMotorcadeOfDepartaments(university.GetDepartamentsList());
                List<DBOMotorcade> dboMotorcades = new List<DBOMotorcade>();
                List<DBOChief> dboChiefs = new List<DBOChief>();
                List<DBOGarage> dboGarages = new List<DBOGarage>();
                List<DBOCar> dboCars = new List<DBOCar>();
                int countMotorcade = 1;
                foreach (Motorcade motorcade in motorcades)
                {
                    dboMotorcades.Add(new DBOMotorcade(motorcade.Name,
                            countMotorcade,
                             dboAddresses.Count(),
                             count));
                    dboChiefs.Add(new DBOChief(motorcade.Chief.Firstname,
                        motorcade.Chief.Lastname,
                        motorcade.Chief.YearOfBirth,
                        countMotorcade,
                         1));
                    dboAddresses.Add(new DBOAddress(dboAddresses.Count(),
                        motorcade.Address.City,
                        motorcade.Address.Street,
                        motorcade.Address.Building,
                        count));
                    List<Garage> garages = new List<Garage>();
                    garages = motorcade.GaragesList;
                    foreach (Garage garage in garages)
                    {
                        dboCars.Add(new DBOCar(garage.Car.Name,
                            garage.Car.Platenumber,
                            dboGarages.Count(),
                            countMotorcade,
                            count));
                        dboGarages.Add(new DBOGarage(garage.Garagenumder,
                            dboGarages.Count(),
                            countMotorcade,
                            count));
                    }
                    dboUniversities.Add(new DBOUniversity(university.Name,
                    dboAddresses.Count(),
                    count));
                    countMotorcade++;
                }
                count++;
                allDBOObjects.Add(new AllDBOObject(dboFaculties, dboDeans, dboStudents,
                 dboAddresses, dboServices, dboHeads, dboAccountants, dboInstitutes, dboManagers,
                 dboEmployees, dboMotorcades, dboChiefs, dboGarages, dboCars,dboUniversities));
            }
            return allDBOObjects;
        }
        public List<University> SaveToJsonDoc(List<University> universities)
        {
            List<University> universitiesList = new List<University>();
            foreach (University university in universities)
            {
                List<Faculty> faculties = new List<Faculty>();
                List<Institute> institutes = new List<Institute>();
                List<Service> services = new List<Service>();
                List<Motorcade> motorcades = new List<Motorcade>();
                    foreach (Departament departament in university.GetDepartamentsList())
                    {
                        if (departament is Faculty)
                        {
                            faculties.Add(departament as Faculty);
                        }
                        if (departament is Service)
                        {
                            services.Add(departament as Service);
                        }
                        if (departament is Institute)
                        {
                            institutes.Add(departament as Institute);
                        }
                        if (departament is Motorcade)
                        {
                            motorcades.Add(departament as Motorcade);
                        }
                    }
                universitiesList.Add(new University(university.Name,
                     university.Address,
                     faculties, services, institutes, motorcades));
            }
            //Student student = new Student("cscs", "vrgverv", 1999, "3 4 5 6");
            //universitiesList[0].FacultiesList[2].AddStudent(student);
            JsonData jsonData = new JsonData(universitiesList);
           // File.WriteAllText("BSUJSon.json", JsonConvert.SerializeObject(universitiesList));
            File.WriteAllText("BSUJsonNew.json", JsonConvert.SerializeObject(jsonData));
            return universitiesList;
            //StreamReader r = new StreamReader("BSUJson.json");
           
            // jsonData = JsonConvert.DeserializeObject<JsonData>(r.ReadToEnd());
            //string json = JsonSerializer.Serialize<List<University>>(universitiesList);
            //universities = JsonConvert.DeserializeObject<University>(r.ReadToEnd());

        }
        public void SaveToXmlDoc(List<AllDBOObject> allDBOObjects)
        {

            XDocument xDoc = new XDocument(
                new XElement("root",
                    new XElement("universities"),
                    new XElement("faculties"),
                    new XElement("deans"),
                    new XElement("students"),
                    new XElement("institutes"),
                    new XElement("managers"),
                    new XElement("employees"),
                    new XElement("services"),
                    new XElement("heads"),
                    new XElement("accountants"),
                    new XElement("cars"),
                    new XElement("garages"),
                    new XElement("motorcades"), 
                    new XElement("chiefs"),
                    new XElement("addresses")));
            foreach (AllDBOObject allDBOObject in allDBOObjects)
            {
                foreach (DBOUniversity dboUniversity in allDBOObject.DBOUniversities)
                {
                    xDoc.Element("root").Elements("universities").Last().Add(new XElement("university",
                        new XAttribute("name", dboUniversity.Name),
                        new XElement("universityID", dboUniversity.UniversityID),
                        new XElement("addressID", dboUniversity.AddressID)));

                }
                foreach (DBOAccountant dboAccountant in allDBOObject.DBOAccountants)
                {
                    xDoc.Element("root").Elements("accountants").Last().Add(new XElement("accountant",
                        new XAttribute("firstname", dboAccountant.Firstname),
                        new XAttribute("lastname", dboAccountant.Lastname),
                        new XElement("yearOfBirth", dboAccountant.YearOfBirth),
                        new XElement("salary", dboAccountant.Salary),
                        new XElement("serviceID", dboAccountant.ServiceID),
                        new XElement("universityID", dboAccountant.UniversityID)));
                }
                foreach (DBOAddress dboAddress in allDBOObject.DBOAddresses)
                {
                    xDoc.Element("root").Elements("addresses").Last().Add(new XElement("address",
                        new XAttribute("addressID", dboAddress.AddressID),
                        new XElement("city", dboAddress.City),
                        new XElement("street", dboAddress.Street),
                        new XElement("building", dboAddress.Building),
                        new XElement("universityID", dboAddress.UniversityID)));

                }
                foreach (DBOCar dboCar in allDBOObject.DBOCars)
                {
                    xDoc.Element("root").Elements("cars").Last().Add(new XElement("car",
                        new XAttribute("name", dboCar.Name),
                        new XElement("platenumber", dboCar.Platenumber),
                        new XElement("garageID", dboCar.GarageID),
                        new XElement("motorcadeID", dboCar.MotorcadeID),
                        new XElement("universityID", dboCar.UniversityID)));
                }
                foreach (DBOChief dboChief in allDBOObject.DBOChiefs)
                {
                    xDoc.Element("root").Elements("chiefs").Last().Add(new XElement("chief",
                        new XAttribute("firstname", dboChief.Firstname),
                        new XAttribute("lastname", dboChief.Lastname),
                        new XElement("yearOfBirth", dboChief.YearOfBirth),
                        new XElement("universityID", dboChief.UniversityID),
                        new XElement("motorcadeID", dboChief.MotorcadeID)));
                }
                foreach (DBODean dboDean in allDBOObject.DBODeans)
                {
                    xDoc.Element("root").Elements("deans").Last().Add(new XElement("dean",
                        new XAttribute("firstname", dboDean.Firstname),
                        new XAttribute("lastname", dboDean.Lastname),
                        new XElement("yearOfBirth", dboDean.YearOfBirth),
                        new XElement("degree", dboDean.Degree),
                        new XElement("facultyID", dboDean.FacultyID),
                        new XElement("universityID", dboDean.UniversityID)));
                }
                foreach (DBOEmployee dboEmployee in allDBOObject.DBOEmployees)
                {
                    xDoc.Element("root").Elements("employees").Last().Add(new XElement("employee",
                        new XAttribute("firstname", dboEmployee.Firstname),
                        new XAttribute("lastname", dboEmployee.Lastname),
                        new XElement("yearOfBirth", dboEmployee.YearOfBirth),
                        new XElement("position", dboEmployee.Position),
                        new XElement("instituteID", dboEmployee.InstituteID),
                        new XElement("universityID", dboEmployee.UniversityID)));
                }
                foreach (DBOFaculty dboFaculty in allDBOObject.DBOFaculties)
                {
                    xDoc.Element("root").Elements("faculties").Last().Add(new XElement("faculty",
                        new XAttribute("name", dboFaculty.FacutyName),
                        new XElement("facultyID", dboFaculty.FacultyID),
                        new XElement("addressID", dboFaculty.AddressID),
                        new XElement("universityID", dboFaculty.UniversityID)));
                }
                foreach (DBOGarage dboGarage in allDBOObject.DBOGarages)
                {
                    xDoc.Element("root").Elements("garages").Last().Add(new XElement("garage",
                        new XAttribute("numder", dboGarage.Garagenumder),
                        new XElement("garageID", dboGarage.GarageID),
                        new XElement("motorcadeID", dboGarage.MotorcadeID),
                        new XElement("universityID", dboGarage.UniversityID)));
                }
                foreach (DBOHead dboHead in allDBOObject.DBOHeads)
                {
                    xDoc.Element("root").Elements("heads").Last().Add(new XElement("head",
                        new XAttribute("firstname", dboHead.Firstname),
                        new XAttribute("lastname", dboHead.Lastname),
                        new XElement("yearOfBirth", dboHead.YearOfBirth),
                        new XElement("experience", dboHead.Experience),
                        new XElement("serviceID", dboHead.ServiceID),
                        new XElement("universityID", dboHead.UniversityID)));
                }
                foreach (DBOInstitute dboInstitute in allDBOObject.DBOInstitutes)
                {
                    xDoc.Element("root").Elements("institutes").Last().Add(new XElement("institute",
                        new XAttribute("name", dboInstitute.InstituteName),
                        new XElement("instituteID", dboInstitute.InstituteID),
                        new XElement("addressID", dboInstitute.AddressID),
                        new XElement("universityID", dboInstitute.UniversityID)));
                }
                foreach (DBOManager dboManager in allDBOObject.DBOManagers)
                {
                    xDoc.Element("root").Elements("managers").Last().Add(new XElement("manager",
                        new XAttribute("firstname", dboManager.Firstname),
                        new XAttribute("lastname", dboManager.Lastname),
                        new XElement("yearOfBirth", dboManager.YearOfBirth),
                        new XElement("roomnumber", dboManager.Roomnumber),
                        new XElement("instituteID", dboManager.InstituteID),
                        new XElement("universityID", dboManager.UniversityID)));
                }
                foreach (DBOMotorcade dboMotorcade in allDBOObject.DBOMotorcades)
                {
                    xDoc.Element("root").Elements("motorcades").Last().Add(new XElement("motorcade",
                        new XAttribute("name", dboMotorcade.MotorcadeName),
                        new XElement("motorcadeID", dboMotorcade.MotorcadeID),
                        new XElement("addressID", dboMotorcade.AddressID),
                        new XElement("universityID", dboMotorcade.UniversityID)));
                }
                foreach (DBOService dboService in allDBOObject.DBOServices)
                {
                    xDoc.Element("root").Elements("services").Last().Add(new XElement("service",
                        new XAttribute("name", dboService.ServiceName),
                        new XElement("serviceID", dboService.ServiceID),
                        new XElement("addressID", dboService.AddressID),
                        new XElement("universityID", dboService.UniversityID)));
                }
                foreach (DBOStudent dboStudent in allDBOObject.DBOStudents)
                {
                    xDoc.Element("root").Elements("students").Last().Add(new XElement("student",
                        new XAttribute("firstname", dboStudent.Firstname),
                        new XAttribute("lastname", dboStudent.Lastname),
                        new XElement("yearOfBirth", dboStudent.YearOfBirth),
                        new XElement("marks", dboStudent.MarksString),
                        new XElement("facultyID", dboStudent.FacultyID),
                        new XElement("universityID", dboStudent.UniversityID)));
                }
            }
            xDoc.Save("BSUnew.xml");
                //Console.WriteLine(xDoc);
        }
    }
}
