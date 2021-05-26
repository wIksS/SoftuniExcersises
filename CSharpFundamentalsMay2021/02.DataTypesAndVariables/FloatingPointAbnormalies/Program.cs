using System;

namespace FloatingPointAbnormalies
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(100000000000000.0f + 0.3);
            //// 100000000000000 (loss of precision)

            //double a = 1.0f, b = 0.33f, sum = 1.33;
            //Console.WriteLine("a+b={0} sum={1} equal={2}",
            //  a + b, sum, (a + b == sum));

            //Console.WriteLine(a + b == 1.33f);


            decimal one = 0;
            for (int i = 0; i < 10000; i++) one += 0.0001m;
            Console.WriteLine(one); // 0.999999999999906









            //double result = 5 / 2.0;
            //Console.WriteLine(10 / 4);    // 2 (integral division)
            //Console.WriteLine(10 / 4.0);  // 2.5 (real division)

            //Console.WriteLine(10 / 0.0);  // Infinity
            //Console.WriteLine(-10 / 0.0); // -Infinity

            //Console.WriteLine(0 / 0.0);   // NaN (not a number)
            //Console.WriteLine(8 % 2.5);   // 0.5 (3 * 2.5 + 0.5 = 8)
        }
    }
}
