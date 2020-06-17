using System;
using System.Collections.Generic;
using System.Linq;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            if (list.Contains("pesho"))
            {
                Console.WriteLine("Pesho go ima");
            }
        }
    }
}
