using System;
using System.Collections.Generic;

namespace Demo.Enumerator.Yield
{
    public class Program
    {
        public static void Main(string[] _)
        {
            var people = Program._getPeople();

            foreach(var person in people)
            {
                Console.WriteLine($"Read person {person.FirstName} {person.LastName}");
            }
        }

        private static IEnumerable<PersonModel> _getPeople()
        {
            yield return new PersonModel("Nelson", "Nobre");
            yield return new PersonModel("Thomas", "Smith");
            yield return new PersonModel("William", "O'Connor");
        }
    }
}