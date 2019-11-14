using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class DBOService
    {
       
        string serviceName;
        
        int serviceID;
       
        int addressID;
        
        int universityID;

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }

        public DBOService(string serviceName, int serviceID, int addressID, int universityID)
        {
           ServiceName = serviceName;
           ServiceID = serviceID;
           AddressID = addressID;
           UniversityID = universityID;
        }
        public int GetServiceID()
        {
            return ServiceID;
        }
        public string GetServiceName()
        {
            return ServiceName;
        }
        public int GetAddressID()
        {
            return AddressID;
        }
    }
}
