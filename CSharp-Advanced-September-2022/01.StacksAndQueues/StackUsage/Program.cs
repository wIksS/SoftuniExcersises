using System;

namespace StackUsage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursion(1);
        }

        static void Recursion(int num)
        {
            if (num > 5)
            {
                return;
            }

            Recursion(num + 1);
        }
    }
}
