using System;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linux, Windows, GNU
            //It is not Linux, it is GNU / Linux.Linux is merely the kernel, while GNU adds the functionality...
           // string dots = new string('!', 1000);
            //Console.WriteLine(dots);

            string[] censoredWords = Console.ReadLine().Split(", ");

            string text = Console.ReadLine();

            foreach (var word in censoredWords)
            {
                // pesho -> *****
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
