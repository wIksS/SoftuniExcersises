using System;

namespace CompareTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // x.CompareTo(y)
            // x < y -> -1
            // x== y -> 0
            // x > y -> 1
            Console.WriteLine(5.CompareTo(6));
            Console.WriteLine(5.CompareTo(5));
            Console.WriteLine(6.CompareTo(5));

            Console.WriteLine("Goshko".CompareTo("Albena"));

        }
    }
}
