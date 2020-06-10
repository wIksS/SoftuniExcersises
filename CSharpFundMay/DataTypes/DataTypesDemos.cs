using System;

namespace DataTypesDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            string os = "Windows";
            string file = "win.ini";
            string path = $@"C:\n{os}\t{file}";

            Console.WriteLine(path);



            return;
            Console.WriteLine("\u01FC");
            Console.WriteLine("\n\n\n\t\t\t5");
            Console.WriteLine("\"");
            Console.WriteLine("\'");
            Console.WriteLine("\\");

            char sht = 'щ';
            Console.WriteLine((int)sht);
            for (int i = 0; i < 26; i++)
            {
                Console.Write((char)(i+65));
                Console.Write((char)(i + 97));

            }














            //int y = (int) (5.5 + 2.5);
            //Console.WriteLine(y);
            //Console.WriteLine("Scientific Notation: " + string.Format("{0:#.##E+0}", 0.002));
            //short x = 5000;
            //byte z = (byte)x;
            //Console.WriteLine(z);
            //Console.WriteLine(100000000000000.0 + 0.3);
            //// 100000000000000 (loss of precision)
            //Console.WriteLine(new string('-', 25));

            //double a = 1.0f, b = 0.33f, sum = 1.33;
            //Console.WriteLine("a+b={0} sum={1} equal={2}",
            //    a + b, sum, (a + b == sum));
            //// a+b=1.33000001311302 sum=1.33 equal = False
            //decimal one = 0;
            //for (int i = 0; i < 10000; i++) one += (decimal)0.0001M;
            //Console.WriteLine(one); // 0.999999999999906

            //Console.WriteLine(new string('-', 50));







            //Console.WriteLine(20e-3);
            //double big = 1000000000560070000000000000000000000000000000000000000000000000.0;
            //Console.WriteLine(big);
            //// 0.05
            //// 107000
            //// 0.000350000
            //// 5931000
            //// 0.007000070000

            //// mantissa R 1 <= m < 10   exponent
            //// 5 * 10^-2
            //// 1.07*10^5
            //// 3.5*10^-4  3.5e-4
            //// 5.931e6
            //// 7.00007e-3
            //double x = 5e-2;
            //Console.WriteLine(x);
            //x = 1.07e5;
            //Console.WriteLine(x);
            //x = 3.5e-4;
            //Console.WriteLine(x);
            //x = 5.931e6;
            //Console.WriteLine(x);
            //x = 7.00007e-3;
            //Console.WriteLine(x);


            //Console.WriteLine(new string('-',50));
            //Console.WriteLine(10 / 4);    // 2 (integral division)
            //Console.WriteLine(10 / 4.0);  // 2.5 (real division)

            //Console.WriteLine(10 / 0.0);  // Infinity
            //Console.WriteLine(-10 / 0.0); // -Infinity

            //Console.WriteLine(0 / 0.0);   // NaN (not a number)
            //Console.WriteLine(8 % 2.5);

        }
    }
}
