using System;
using System.Text;

namespace SBMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder sb = new StringBuilder();
           // sb += "Hello";
            sb.Append("Hello");
            sb.Insert(2, "Sup");

           // sb.Replace("Hello", "Goodbye");

            Console.WriteLine(sb);
            Console.WriteLine(sb[0]);
            Console.WriteLine(sb[sb.Length-1]);

        }
    }
}
