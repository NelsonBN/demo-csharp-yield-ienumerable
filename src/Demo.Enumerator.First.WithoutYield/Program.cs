using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Enumerator.First.WithoutYield
{
    public class Program
    {
        public static void Main(string[] _)
        {
            var people = _getPeople();

            var firstPerson = people.First();
            Console.WriteLine($"Read first person {firstPerson.FirstName} {firstPerson.LastName}");
        }

        private static IEnumerable<PersonModel> _getPeople()
        {
            var people = new List<PersonModel>();

            people.Add(new PersonModel("Nelson", "Nobre"));
            people.Add(new PersonModel("Thomas", "Smith"));
            people.Add(new PersonModel("William", "O'Connor"));

            return people;
        }
    }
}