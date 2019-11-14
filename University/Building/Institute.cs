using System.Collections.Generic;
using Newtonsoft.Json;
namespace test2
{
    public class Institute : Departament
    {
        
        Manager manager;
       
        List<Employee> employeesList = new List<Employee>();

        public Institute(string nm, Address address, Manager manager, List<Employee> employees) : base(nm, address)
        {
            Manager = manager;
            EmployeesList = employees;


        }
        [JsonProperty("manager")]
        public Manager Manager { get => manager; set => manager = value; }
        [JsonProperty("employee")]
        public List<Employee> EmployeesList { get => employeesList; set => employeesList = value; }

        public bool AddEmployee(Employee X)
        {
            foreach (Employee empl in employeesList)
            {
                if (X.Equals(empl))
                {
                    return false;
                }
            }
            employeesList.Add(X);
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is Institute institute &&
                   base.Equals(obj) &&
                   EqualityComparer<Manager>.Default.Equals(manager, institute.manager) &&
                   EqualityComparer<List<Employee>>.Default.Equals(employeesList, institute.employeesList);
        }

        

        public override string ToString()
        {
            return base.ToString() + ", Manager: " + $"{manager.ToString()}";
        }
    }
}
