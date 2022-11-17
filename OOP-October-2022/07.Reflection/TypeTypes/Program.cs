using System;

namespace TypeTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type compileTimeType = typeof(Console);
            Type runtimeType = Type.GetType(Console.ReadLine());// Console.ReadLine());

            Type objType = new DateTime().GetType();

            Console.WriteLine(runtimeType.FullName);
        }
    }
}
