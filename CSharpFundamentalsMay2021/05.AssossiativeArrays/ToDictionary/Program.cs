using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names =  { "pesho", "gosho", "teti", "pessssho" };

            // key -> name value -> length

            Dictionary<string, int> namesLength =
                names.ToDictionary(p => p, p => p.Length);

            foreach (var item in namesLength)
            {
                Console.WriteLine(item);
            }
        }
    }
}
