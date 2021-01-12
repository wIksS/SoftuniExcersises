using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            //2 + 5 + 10 - 2 - 1
            Stack<string> expression = new Stack<string>(new Stack<string>(input));


            while (expression.Count > 1)
            {
                int leftNumber = int.Parse(expression.Pop());
                string sign = expression.Pop();
                int rightNumber = int.Parse(expression.Pop());

                if (sign == "+")
                {
                    expression.Push((leftNumber + rightNumber).ToString());
                }
                else if (sign == "-")
                {
                    expression.Push((leftNumber - rightNumber).ToString());
                }
            }

            Console.WriteLine(expression.Pop());
        }
    }
}
