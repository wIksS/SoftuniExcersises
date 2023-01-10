using System;
using System.Collections.Generic;

namespace _03.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5+(6 +2)+((3 -1)-9)
            string expression = Console.ReadLine();
            Stack<int> openBracketIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBracketIndexes.Push(i);
                }
                if (expression[i] == ')')
                {
                     // (1 + 2)
                    int openBracket = openBracketIndexes.Pop();

                    for (int j = openBracket; j <= i; j++)
                    {
                        if (expression[j] == ' ')
                        {
                            continue;
                        }
                        Console.Write(expression[j]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
