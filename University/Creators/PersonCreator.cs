using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test2 
{
   public static class PersonCreator
    {
        public static Person CreateFromConsole(string personType, Person person)
        {
            Console.WriteLine("Input "+ personType + " firstName");
            person.Firstname = Console.ReadLine();
            Console.WriteLine("Input " + personType + " lastName");
            person.Lastname = Console.ReadLine();
            Console.WriteLine("Input " + personType + " year of birth");
            person.YearOfBirth = Int32.Parse(Console.ReadLine());
            return person;
        }
    }
}
