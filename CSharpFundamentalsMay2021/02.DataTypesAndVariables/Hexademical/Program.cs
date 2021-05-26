using System;

namespace Hexademical
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 35l;

            var number = 45l;
            Console.WriteLine(number.GetType().Name);
            int hex = 0x111111;
            Console.WriteLine(hex);
        }
    }
}
