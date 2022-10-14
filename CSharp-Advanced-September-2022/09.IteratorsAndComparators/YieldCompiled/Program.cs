using System;
using System.Collections.Generic;

namespace YieldCompiled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IEnumerator<int> ForEach()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
