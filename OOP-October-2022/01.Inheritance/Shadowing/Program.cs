using System;

namespace Shadowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Add(-1);

            //c.Hello();
        }
    }

    class Parent
    {
        public int number = 5;

        public void Hello()
        {
            Console.WriteLine("Hello from Parent");
        }
    }

    class Child : Parent
    {
        public int number = 8;

        public void Add(int number)
        {
            Console.WriteLine($"Param {number}");
            Console.WriteLine($"Child {this.number}");
            Console.WriteLine($"Parent {base.number}");
        }

        public void Hello()
        {
            base.Hello();
            Console.WriteLine("Hello from Child");
        }
    }
}
