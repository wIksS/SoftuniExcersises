using System;

namespace RefConstraint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Y(ref int num)
        {
            X<int>
        }
    }

    class X<T> where T: class
    {

    }
}
