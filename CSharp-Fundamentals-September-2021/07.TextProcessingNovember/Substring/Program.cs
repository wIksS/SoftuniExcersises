using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex =int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            string text = "Substrings are cool";

            string substring = text.Substring(startIndex, endIndex - startIndex);
            Console.WriteLine(substring);
        }
    }
}
