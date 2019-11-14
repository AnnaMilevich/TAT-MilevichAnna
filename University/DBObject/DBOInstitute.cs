using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class DBOInstitute
    {
       
        string instituteName;
        
        int instituteID;
        
        int addressID;
    
        int universityID;

        public string InstituteName { get => instituteName; set => instituteName = value; }
        public int InstituteID { get => instituteID; set => instituteID = value; }
        public int AddressID { get => addressID; set => addressID = value; }
        public int UniversityID { get => universityID; set => universityID = value; }

        public DBOInstitute(string instituteName, int instituteID, int addressID, int universityID)
        {
            InstituteName = instituteName;
            InstituteID = instituteID;
            AddressID = addressID;
            UniversityID = universityID;
        }
        public int GetInstituteID()
        {
            return InstituteID;
        }
        public string GetInstituteName()
        {
            return InstituteName;
        }
        public int GetAddressID()
        {
            return AddressID;
        }
    }
}
