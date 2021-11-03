using System;
using System.Collections.Generic;

namespace _02.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordSynonyms.ContainsKey(word))
                {
                    //wordSynonyms.Add(word, new List<string>());
                    wordSynonyms[word] = new List<string>();
                }

                wordSynonyms[word].Add(synonym);
            }

            foreach (var word in wordSynonyms)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
