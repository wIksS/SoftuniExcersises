using System;
using System.IO;
using System.Threading;

namespace _04.Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Viktor\source\repos\04.Streams\04.Streams\cooltext.txt");

            // connection
           
            string textFromFile = reader.ReadToEnd();

            Console.WriteLine(textFromFile);

            reader.Close();

            using (StreamReader readerWithUsing = new StreamReader(@"C:\Users\Viktor\source\repos\04.Streams\04.Streams\cooltext.txt"))
            {
                textFromFile = readerWithUsing.ReadToEnd();

                var row = readerWithUsing.ReadLine();
                Console.WriteLine(textFromFile);
            }
        }
    }
}
