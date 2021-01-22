using System;
using System.Collections.Generic;
using System.IO;

namespace StreamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File:");
            Console.WriteLine(File.ReadAllText("../../../input.txt"));
            return;
            using (StreamReader reader = new StreamReader(@"C:\Users\User\source\repos\StreamsAndFiles\StreamsAndFiles\input.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            using (StreamWriter streamWriter = new StreamWriter(""))
            {

            }


                StreamWriter writer = new StreamWriter(@"C:\Users\User\source\repos\StreamsAndFiles\StreamsAndFiles\input.txt", true);

            writer.WriteLine("Files are cuul");
            writer.Close();
        }
    }
}
