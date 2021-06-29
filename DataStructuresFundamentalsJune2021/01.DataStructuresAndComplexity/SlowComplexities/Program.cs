using System;
using System.Diagnostics;

namespace SlowComplexities
{
    class Program
    {
        static int count = 0;
        static unsafe void Main(string[] args)
        {
            int x = 5;
            int* y = &x;

            Console.WriteLine((int)(&x));
            Console.WriteLine((int)y);
            Console.WriteLine((int)&y);


            int n = int.Parse(Console.ReadLine());
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Algorithm(n);
                
            watch.Stop();
            Console.WriteLine($"Count: { count }");
            Console.WriteLine($"Time {watch.ElapsedMilliseconds}");
        }

        // O(2^n)
        static void Algorithm(int n)
        {
            if (n == 0)
            {
                return;
            }

            for (int i = 0; i < n; i++)
            {
                Algorithm(n - 1);
            }
            count++;
            //Algorithm(n - 1);
        }
    }
}
