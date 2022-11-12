using System;

namespace ConstructorHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class A
    {
        public A(int x)
        {

        }

        public A(string x)
        {

        }
    }

    class B : A
    {
        public B(int x):base(x)
        {

        }

        public B(string x) : base(x)
        {

        }
    }

    class C : B
    {
        public C() : base("")
        {

        }
    }
}
