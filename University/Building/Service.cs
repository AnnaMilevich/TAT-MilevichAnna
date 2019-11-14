using System.Collections.Generic;
using Newtonsoft.Json;
namespace test2
{
    public class Service : Departament
    {
       
        Head head;
        List<Accountant> accountantsList = new List<Accountant>();

        public Service(string nm, Address dA, Head head, List<Accountant> accountantsList) : base(nm, dA)
        {
            Head = head;
            AccountantsList = accountantsList;

        }
        [JsonProperty("head")]
        public Head Head { get => head; set => head = value; }
        [JsonProperty("accountant")]
        public List<Accountant> AccountantsList { get => accountantsList; set => accountantsList = value; }

        public bool AddAccountan(Accountant X)
        {
            foreach (Accountant acc in accountantsList)
            {
                if (X.Equals(acc))
                {
                    return false;
                }
            }
            accountantsList.Add(X);
            return true;

        }

        public override bool Equals(object obj)
        {
            return obj is Service service &&
                   base.Equals(obj) &&
                   EqualityComparer<Head>.Default.Equals(head, service.head) &&
                   EqualityComparer<List<Accountant>>.Default.Equals(accountantsList, service.accountantsList);
        }

      
        public override string ToString()
        {
            return base.ToString() + ", Head: " + $"{head.ToString()}";
        }

    }
}
