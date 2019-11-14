using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Linq;
using Newtonsoft.Json;

namespace test2
{
    [Serializable]
    public class University
    {
       
      
        string name;
        
        Address address;
        [NonSerialized]
        List<Departament> departamentsList = new List<Departament>();
        List<Faculty> faculties = new List<Faculty>();
        List<Service> services = new List<Service>();
        List<Institute> institutes = new List<Institute>();
        List<Motorcade> motorcades = new List<Motorcade>();

        [JsonProperty("faculty")]
        public List<Faculty> FacultiesList { get=>faculties; set=>faculties=value; }
        [JsonProperty("institute")]
        public List<Institute> InstitutesList { get=>institutes; set=>institutes=value; }
        [JsonProperty("service")]
        public List<Service> ServicesList { get=>services; set=>services=value; }
        [JsonProperty("motorcade")]
        public List<Motorcade> MotorcadesList { get=>motorcades; set=>motorcades=value; }

        public University()
        {

        }

        public University(string name, Address address, List<Departament> departaments)
        {
            Name = name;
            Address = address;
            DepartamentsList = departaments;
        }
        public University(string name, Address address, List<Faculty> faculties,List<Service> services,List<Institute> institutes, List<Motorcade> motorcades)
        {
            Name = name;
            Address = address;
            FacultiesList = faculties;
            InstitutesList = institutes;
            MotorcadesList = motorcades;
            ServicesList = services;
        }

        public University(List<Departament> departaments)
        {
            this.DepartamentsList = departaments;
        }
        private List<Departament> DepartamentsList { get => departamentsList; set => departamentsList = value; }
        [JsonProperty("name")]
        public string Name { get => name; set => name = value; }
        [JsonProperty("address")]
        public Address Address { get => address; set => address = value; }
        public List<Departament> GetDepartamentsList()
        {
            List<Departament> departamentsList = DepartamentsList;
            return departamentsList;
        }

        public University AddDepartament(Departament X)
        {
            if (!DepartamentsList.Contains(X) && DepartamentsList.Count < 12)
            {
                DepartamentsList.Add(X);
                if (X is Faculty)
                {
                    (X as Faculty).StudentAdded += PrintInfo;
                }
            }
            return this;
        }
        

        public List<Faculty> GetFacultyOfDepartaments(List<Departament> departaments)
        {
            return (from Departament departament in departaments
                    where departament is Faculty
                    select departament as Faculty).ToList();
        }
        public List<Institute> GetInstituteOfDepartaments(List<Departament> departaments)
        {
            return (from Departament departament in departaments
                    where departament is Institute
                    select departament as Institute).ToList();
        }
        public List<Service> GetServiceOfDepartaments(List<Departament> departaments)
        {
            return (from Departament departament in departaments
                    where departament is Service
                    select departament as Service).ToList();
        }
        public List<Motorcade> GetMotorcadeOfDepartaments(List<Departament> departaments)
        {
            return (from Departament departament in departaments
                    where departament is Motorcade
                    select departament as Motorcade).ToList();
        }

        //public University AddDepartament(List<Faculty> faculties )
        //{
        //    if (!DepartamentsList.Contains(fa) && DepartamentsList.Count < 12)
        //    {
        //        DepartamentsList.Add(X);
        //        if (X is Faculty)
        //        {
        //            (X as Faculty).StudentAdded += PrintInfo;
        //        }
        //    }
        //    return this;
        //}
        public void PrintInfo(string message)
        {
            Console.WriteLine(message);
        }



        //public override string ToString()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        return $"{departaments[i].ToString()}";
        //    }

        //return ".";
        //return $"{departaments[7].ToString()}";

    }


}
