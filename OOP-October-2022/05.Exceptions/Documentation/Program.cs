using System;

namespace Documentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DivideTwoNumbers(5,0);
        }


        /// <exception cref="DivideByZeroException">paramer b could be 0</exception>
        /// <returns cref="Int32">cref="Int32"</returns>
        public static int DivideTwoNumbers(int a, int b)
        {
            return a / b;
        }
    }
}
