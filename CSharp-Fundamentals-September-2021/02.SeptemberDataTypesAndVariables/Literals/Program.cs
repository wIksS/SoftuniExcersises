using System;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            long longNum = 5500000000000000;
            Console.WriteLine(longNum);
            int num = (int)longNum;
            Console.WriteLine(num);
            float x = 0.55f;
            long number = 0xfeabc32234215;

            long longNumber = 55l;
            Console.WriteLine(number);
        }
    }
}
