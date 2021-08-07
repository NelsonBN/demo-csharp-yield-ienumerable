using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Enumerator.First.Yield
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
            yield return new PersonModel("Nelson", "Nobre");
            yield return new PersonModel("Thomas", "Smith");
            yield return new PersonModel("William", "O'Connor");
        }
    }
}