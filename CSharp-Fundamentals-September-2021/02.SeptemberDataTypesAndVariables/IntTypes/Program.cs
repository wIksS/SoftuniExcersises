using System;
using System.Numerics;
using System.Threading;

namespace IntTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigNumber = 5;
            while (true)
            {
                bigNumber *= 2;
                Console.WriteLine(bigNumber);
                Thread.Sleep(100);
            }

            sbyte sbyteNumber = 127;
            byte byteNumber = 254;

            int intNumber = 2147436543;
            long longNumber = 2147436543000000000;

            long maxInt = 0;
            while (true)
            {
               // Console.WriteLine(maxInt);
                maxInt+=100000000000000000;
                Console.WriteLine(maxInt);
            }



            //Console.WriteLine(byteNumber);
        }
    }
}
