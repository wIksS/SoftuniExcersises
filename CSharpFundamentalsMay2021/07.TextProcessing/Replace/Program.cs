using System;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "some text with email with electronic email with cool email";

            text = text.Replace("email", "telephone");

            Console.WriteLine(text);
        }
    }
}
