using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public class Employee : Person
    {
       
        string position;

        [JsonProperty("position")]
        public string Position { get => position; set => position = value; }
    

        public Employee(string frstnm, string lstnm, int y, string pstn) : base(frstnm, lstnm, y)
        {
            Position = pstn;
     
        }
       
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
