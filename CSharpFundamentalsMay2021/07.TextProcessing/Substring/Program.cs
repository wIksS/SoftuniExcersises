using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Tova e dylyg i mnogo smislen tekst";

            int start = 3;
            // 15 -3 = 12
            int end = text.Length;
            string substring = text.Substring(start, end - start);

            Console.WriteLine($"String: {text}");
            Console.WriteLine($"Substring(3,10): {substring}");
        }
    }
}
