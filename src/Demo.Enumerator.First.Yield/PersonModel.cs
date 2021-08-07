using System;

namespace Demo.Enumerator.First.Yield
{
    public class PersonModel
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public PersonModel(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            Console.WriteLine($"Initialized person: {this.FirstName} {this.LastName}");
        }
    }
}