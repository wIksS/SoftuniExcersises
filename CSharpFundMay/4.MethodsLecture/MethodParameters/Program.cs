using System;

namespace MethodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            Console.ReadLine();

            Calculator(ref firstNum, 10, "+");
            Calculator(21, 5.55, "-");

        }



        static void Calculator(ref double first, double second, string sign)
        {
            double result = 0;
            if (sign == "+")
            {
                result = first + second;
            }
            if (sign == "/")
            {
                result = first / second;
            }
            if (sign == "*")
            {
                result = first * second;
            }
            if (sign == "-")
            {
                result = first - second;
            }

            Console.WriteLine(result);
        }
    }
}
