using Newtonsoft.Json;
using System;

namespace test2
{
    public class Head : Person
    {
       
        int experience;
       
        public Head()
        {

        }
        public Head(string frstnm, string lstnm, int y, int exprnc) : base(frstnm, lstnm, y)
        {
            Experience = exprnc;
           
        }
        [JsonProperty("experience")]
        public int Experience { get => experience; set => experience = value; }
       
        public override string ToString()
        {
            return base.ToString() + ", experience: " + $"{Experience}";
        }
    }

}
