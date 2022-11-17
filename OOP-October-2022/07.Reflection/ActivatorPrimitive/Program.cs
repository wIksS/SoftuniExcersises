using System;

namespace ActivatorPrimitive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = (int)Activator.CreateInstance(typeof(int)) + 5;

            Console.WriteLine(num);
        }
    }
}
