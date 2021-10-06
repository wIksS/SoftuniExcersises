using System;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] towns =
            {
                "Sofia",
                "Sliven",
                "Stara Zagara",
                "Dolno Nanagorsnihte"
            };

            foreach(var town in towns)
            {
                Console.WriteLine(town);
            }

            foreach (int item in new int[] { 1, 2, 3, 4 })
            {
                Console.WriteLine(item);
            }           
        }
    }
}
