using System;

namespace Funcs
{
    class Program
    {
        //5
        //6
        //+
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            Func<int,int,int> calcMethod = GetCalcMethod(sign);

            Console.WriteLine(calcMethod(x, y));
        }

        static int Default(int x, int y)
        {
            return -1;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static Func<int,int,int> GetCalcMethod(string input)
        {
            switch (input)
            {
                case "*": return Multiply;
                case "+":
                    return Sum;
                case "-":
                    return Subtract;
                default:
                    return Default;
            }
        }
    }
}
