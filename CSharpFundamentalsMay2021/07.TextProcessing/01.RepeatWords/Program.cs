using System;

namespace _01.RepeatWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            string result = "";

            // hi pesho
            for (int i = 0; i < words.Length; i++)
            {
                //pesho
                for (int j = 0; j < words[i].Length; j++)
                {
                    result += words[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
