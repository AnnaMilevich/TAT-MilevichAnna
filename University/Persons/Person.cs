
using Newtonsoft.Json;
using System;
using System.Collections.Generic; 

namespace test2
{
    [Serializable]
    public class Person
    {
        string firstname;
        string lastname;
        int yearOfBirth;
        [JsonProperty("firstname")]
        public string Firstname { get => firstname; set => firstname = value; }
        [JsonProperty("lastname")]
        public string Lastname { get => lastname; set => lastname = value; }
        [JsonProperty("yearofbirth")]
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }

        public Person()
        {

        }
        public Person(string fnm, string lstnm, int y)
        {
            Firstname = fnm;
            Lastname = lstnm;
            YearOfBirth = y;

        }
        public override bool Equals(object obj)
        {
            Person st = obj as Person;

            return (Firstname == st?.Firstname) && (Lastname == st?.Lastname) && (YearOfBirth == st?.YearOfBirth);
        }
        public override string ToString()
        {
            return $"{Firstname}, {Lastname}, {YearOfBirth}";
        }
        public string GetLastName()
        {
            return Lastname;
        }
        public string GetFirstName()
        {
            return Firstname;
        }
    }
}
