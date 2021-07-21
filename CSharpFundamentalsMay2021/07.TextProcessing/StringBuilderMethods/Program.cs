using System;
using System.Text;

namespace StringBuilderMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            // text = "..";
            text.Append("some cool text here.Very cool text");

            text.Insert(0, "This is ");

            text.Replace("cool", "ugly");

            Console.WriteLine(text);
            Console.WriteLine(text[0]);
            Console.WriteLine(text.Length);
        }
    }
}
