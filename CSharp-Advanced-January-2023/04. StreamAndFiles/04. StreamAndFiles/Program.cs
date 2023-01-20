using System;
using System.IO;

namespace _04._StreamAndFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string input = reader.ReadToEnd();

                Console.WriteLine(input);
            }

            Console.WriteLine("Stream is closed");

  
        }
    }
}
