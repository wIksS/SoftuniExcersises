using System;
using System.Text;

namespace StringBuilderExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = "What is up?" ;
            StringBuilder text = new StringBuilder(initial);

            text.Clear();

            text.AppendLine("Hello");
            text.Append(" Dimitrichko");


            initial = text.ToString();

            Console.WriteLine(initial);
        }
    }
}
