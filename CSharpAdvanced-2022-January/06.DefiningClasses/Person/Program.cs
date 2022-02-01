using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("Pesho");

            var name = person.GetName();

            Console.WriteLine(person.GetName());

            Console.WriteLine(person.GetName());
        }
    }

    class Person
    {
        // fields
        private string name;

        //constructors

        // properties

        //methods
        public string GetName()
        {
            Console.WriteLine("In getter");
            return this.name;
        }

        public void SetName(string value)
        {
            Console.WriteLine("In setter");
            this.name = value;
        }
        //public string Name
        //{
        //    get
        //    {
        //        Console.WriteLine("In getter");
        //        return this.name;
        //    }
        //    set
        //    {
        //        Console.WriteLine("In setter");
        //        this.name = value;
        //    }
        //}
    }
}
