using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child  = new Child();
            child.Number = 7;
            child.Name = "Child";

            child.Print();
        }
    }

    class Parent
    {
        public int Number { get; set; }
    }

    class Child : Parent
    {
        public string Name { get; set; }
       
        public void Print()
        {
            Console.WriteLine(base.Number);
            Console.WriteLine($"{Name}:{Number}");
        }
    }
}
