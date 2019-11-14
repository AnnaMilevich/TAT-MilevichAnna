
using Newtonsoft.Json;

namespace test2
{
    public class Accountant : Person
    {
        
        int salary;
        public Accountant(string frstnm, string lstnm, int y, int slr) : base(frstnm, lstnm, y)
        {
            Salary = slr;
        }
        [JsonProperty("salary")]
        public int Salary { get => salary; set => salary = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        //public int GetServiceID()
        //{
        //    return ServiceID;
        //}

    }
}
