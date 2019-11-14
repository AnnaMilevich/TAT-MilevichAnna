using Newtonsoft.Json;

namespace test2
{
    public class Manager : Person
    {
        int roomnumber;
     
        public Manager()
        {

        }
        public Manager(string frstnm, string lstnm, int y, int rmnmb) : base(frstnm, lstnm, y)
        {
            Roomnumber = rmnmb;
        }
        [JsonProperty("roomnumber")]
        public int Roomnumber { get => roomnumber; set => roomnumber = value; }
        public override string ToString()
        {
            return base.ToString() + ", roomnumder: " + $"{Roomnumber}";
        }
    }
}
