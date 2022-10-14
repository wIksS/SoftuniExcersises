using System;

namespace This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            X x = new X(5);
            Console.WriteLine(x.y);
        }
    }

    class X
    {
        public int y;

        public X(int y)
        {
            y = y;
        }

    }
}
