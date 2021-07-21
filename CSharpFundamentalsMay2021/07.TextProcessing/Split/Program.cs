using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            //string removed = Console.ReadLine();
            //string[] input = Console.ReadLine().Split(removed);
            //Console.WriteLine(String.Join("",input));

            string text = "This is some text. This text is cool,,,,,         correct and cool.";
            string[] words = text.Split(new char[] { ' ', '.', '!', ',' }
            , StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
