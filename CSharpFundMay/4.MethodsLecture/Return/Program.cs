using System;
using System.Collections.Generic;

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Hello("Bai pesho");

            Console.WriteLine(result);
            Console.WriteLine(Sum(5,6));
            int division = Division(10, 5);
            Console.WriteLine(Sum(Division(10,5), division));
            string x = Console.ReadLine();
            Console.WriteLine(int.Parse(SoftuniReadLine()));
            Console.WriteLine(ReadNumber());

            int result2 = ReadNumber();
        }

        static void Print()
        {

        }
        static int ReadNumber()
        {
            return int.Parse(Console.ReadLine());
        }
        static string SoftuniReadLine()
        {
            return Console.ReadLine();
        }
        static int Sum(int first, int second)
        {
            return first + second;
        }

        static int Division(int first, int second)
        {
            return first / second;
        }

        static string Hello(string name)
        {
            string hello = $"Hello {name}, nice to meet you!";

            return hello;
        }
    }
}
