using System;

namespace RealTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            float scientific = 1e-2f;
            Console.WriteLine(scientific);
            float num = (float)2.1474365430032131200000000000010000000000f;
            Console.WriteLine(num);

            double doubleNum = 2.14743654331231232131231231231231231212331321312000D;
            Console.WriteLine(doubleNum);
            Console.WriteLine("-----------------");
            Console.WriteLine(10 / 4);    // 2 (integral division)
            Console.WriteLine(10 / 4.0);  // 2.5 (real division)

            Console.WriteLine(10 / 0.0);  // Infinity
            Console.WriteLine(-10 / 0.0); // -Infinity

            Console.WriteLine(0 / 0.0);   // NaN (not a number)
            Console.WriteLine(8 % 2.5);   // 0.5 (3 * 2.5 + 0.5 = 8)

        }
    }
}
