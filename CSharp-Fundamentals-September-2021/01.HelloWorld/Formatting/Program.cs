using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = $"Today is: {DateTime.Now} 5 + 5 = {5+5}";
            Console.WriteLine($"3*2/3={3*2/3}");

            int month = 10;
            Console.WriteLine($"{month:D2}");
            double grade = 5.55994343434;
            Console.WriteLine($"{grade:f0}");
        }
    }
}
