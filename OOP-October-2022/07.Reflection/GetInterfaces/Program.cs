using System;
using System.Collections.Generic;

namespace GetInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Type type = list.GetType();

            Type[] interfaces = type.GetInterfaces();

            foreach (Type interfaceType in interfaces)
            {
                Console.WriteLine(interfaceType.Name);
            }
        }
    }
}
