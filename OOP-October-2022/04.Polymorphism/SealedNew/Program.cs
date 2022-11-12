using System;

namespace SealedNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Base
    {
        protected virtual void Test() { }
    }

    class Child : Base
    {
        protected sealed override void Test() { }
    }

    class ChildChild: Child
    {
        protected new void Test() { }
    }
}
