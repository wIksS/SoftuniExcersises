using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(Division(x,n,d));
        }

        static int Division(int x, int n, int d)
        {
            if (n == 0)
            {
                return x;
            }
            int division = Division(x, n - 1, d);
            return division / d;
        }
    }
}
