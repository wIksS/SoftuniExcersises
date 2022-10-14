using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldReturn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerator<int> enumerator = Print();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static IEnumerator<int> Print()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }

            //Console.WriteLine("Before first yield");

            //yield return 3;

            //Console.WriteLine("Before second yield");

            //yield return 4;

            //yield return 5;

            //yield return 6;

        }
    }
}
