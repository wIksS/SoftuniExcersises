using System;

namespace _03.Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                text = text.Replace(bannedWord, new string('*',bannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
