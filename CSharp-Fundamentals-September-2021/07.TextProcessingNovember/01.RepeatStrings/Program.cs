using System;
using System.Linq;

namespace _01.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string result = String.Empty;

            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
