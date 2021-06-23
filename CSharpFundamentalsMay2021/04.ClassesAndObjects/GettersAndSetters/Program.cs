using System;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.FirstName);

            person.FirstName = "Pesho";
            person.FirstName = "Goshof";
            person.LastName = "Petrov";

            Console.WriteLine(person.FirstName);

            Console.WriteLine(person.FullName);

        }
    }
}
