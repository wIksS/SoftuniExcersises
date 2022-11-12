using System;

namespace ReturnThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();

            Parent child2 = child.Method();
        }
    }

    class Parent
    {

    }

    class Child : Parent
    {
        public Parent Method()
        {
            return this;
        }
    }
}
