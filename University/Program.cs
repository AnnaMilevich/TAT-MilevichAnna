using System;
using System.Xml.Linq;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Threading.Tasks;


namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBProvider provider = new JSONProvider("BSUJson.json");
            
            //IDBProvider provider= new XMLProvider("BSU.xml");
          

            CreatorUniversity managerCreator = new CreatorUniversity(provider);
            List<University> universities = managerCreator.Universities();
          
            List<University> universitiesList = managerCreator.SaveToJsonDoc(universities);

           // managerCreator.SaveToJsonDoc(universities);

            // List<AllDBOObject> allDBOObjects=managerCreator.GetAllDBOObjects(universities);
            
            // managerCreator.SaveToXmlDoc(allDBOObjects)
           
        }

    }
}
