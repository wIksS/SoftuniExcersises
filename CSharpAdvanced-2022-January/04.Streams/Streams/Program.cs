using System;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryStream stream = new MemoryStream();

            byte[] buffer = new byte[] { 1, 2, 3, 4, 5, };
            stream.Write(buffer, 0, buffer.Length);

            byte[] read = new byte[2];

            stream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(stream.Read(read, 0, 2));
            Console.WriteLine(string.Join(",", read));

            Console.WriteLine(stream.Read(read, 0, 2));
            Console.WriteLine(string.Join(",", read));

            Console.WriteLine(stream.Read(read, 0, 2));
            Console.WriteLine(string.Join(",", read));

            Console.WriteLine(stream.Read(read, 0, 2));

        }
    }
}
