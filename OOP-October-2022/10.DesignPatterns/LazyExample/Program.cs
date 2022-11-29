using System;

namespace LazyExample
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Lazy<Student> lazy = new Lazy<Student>(() =>
            {
                Console.WriteLine("Called only when lazy is used");
                return new Student("Pesho");
            });

            Console.WriteLine("Hey");

            Console.WriteLine(lazy.Value.Name);
        }
    }
}
