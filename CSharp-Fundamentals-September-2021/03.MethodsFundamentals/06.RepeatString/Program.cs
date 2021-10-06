using System;

namespace _06.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeated = RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine()));

            Console.WriteLine(repeated);
        }

        static string RepeatString(string value, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += value;
            }

            return result;
        }
    }
}
