using System;

namespace Splitting
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = ",,,,,,,,,,,,Lorem ipsum, hello! How are you, I am fine. You?";
            string[] splitted = text.Split(new string[] { ",", " ", "!", "." }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(text);
            foreach (var item in splitted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
