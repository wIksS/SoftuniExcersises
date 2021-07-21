using System;

namespace _02.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            // remove word
            // text
            // while indexOf word >= 0 
            // remove from text

            //ice
            //kicegiceiceb

            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int indexOfWord = text.IndexOf(wordToRemove);

            while (indexOfWord >= 0)
            {
                // extension method
                text = text.Remove(indexOfWord, wordToRemove.Length);
                indexOfWord = text.IndexOf(wordToRemove);
            }

            Console.WriteLine(text);
        }
    }
}
