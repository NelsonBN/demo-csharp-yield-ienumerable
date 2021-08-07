using System;
using System.Collections.Generic;

namespace Demo.EnumerableObjects.WithoutYield
{
    public class Program
    {
        public static void Main(string[] _)
        {
            var people = _getPeople();

            foreach(var person in people)
            {
                Console.WriteLine($"Read person {person.FirstName} {person.LastName}");
            }
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