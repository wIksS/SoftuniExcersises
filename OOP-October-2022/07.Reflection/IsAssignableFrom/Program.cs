using System;

namespace IsAssignableFrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(object);

            Console.WriteLine(type.IsAssignableFrom(typeof(Sheep)));

            Animal sheep = new Sheep();
        }
    }

    abstract class Animal
    {
        public void Sleep ()
        {
            Console.WriteLine("Sleep");
        }
    }

    class Sheep : Animal
    {
        public int MyProperty { get; set; }
    }
}
