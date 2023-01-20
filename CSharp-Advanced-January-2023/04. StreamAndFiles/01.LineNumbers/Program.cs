using System;
using System.IO;

namespace _01.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../lines.txt"))
            {
                string line = reader.ReadLine();
                int row = 0;
                while (line != null)
                {
                    Console.WriteLine($"{++row}.{line}");
                    line = reader.ReadLine();
                }
            }
        }
    }
}
