using System;

namespace VarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "pesho";
            if (x is var result)
            {
                Console.WriteLine(result);
            }
        }
    }
}
