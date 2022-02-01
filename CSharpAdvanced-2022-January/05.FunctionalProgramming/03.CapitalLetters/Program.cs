using System;
using System.Linq;

namespace _03.CapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> isStartWithCapital = w => Char.IsUpper(w[0]);

            Console.WriteLine(String.Join("\n", words.Where(x => isStartWithCapital(x))));
        }
    }
}
