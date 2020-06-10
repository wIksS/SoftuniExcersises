using System;
using System.Diagnostics;
using System.Text;

namespace _06.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatStringFast(input,n));
           // Stopwatch timer = Stopwatch.StartNew();

            //RepeatString(input,n);
            //timer.Stop();
            //Console.WriteLine(timer.ElapsedMilliseconds);
            //timer = Stopwatch.StartNew();
            //RepeatStringFast(input, n);
            //timer.Stop();
            //Console.WriteLine(timer.ElapsedMilliseconds);
        }

        static string RepeatStringFast(string toRepeat, int times)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(toRepeat);
            }

            return result.ToString();
        }

        static string RepeatString(string toRepeat, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += toRepeat;
            }

            return result;
        }
    }
}
