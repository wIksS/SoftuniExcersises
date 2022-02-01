using System;
using System.IO;
using System.Text;

namespace FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            //string text = "pesho";
            //using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate))
            //{
            //    Console.WriteLine(stream.Length);
            //    stream.Seek(stream.Length, SeekOrigin.Begin);
            //    byte[] data = Encoding.UTF8.GetBytes(text);
            //    Console.WriteLine($"{string.Join(",", data)}");
            //    stream.Write(data, 0, data.Length);
            //}

            using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate))
            {
                byte[] data = new byte[5];

                while (stream.Read(data, 0, data.Length) > 0)
                {
                    string text = Encoding.UTF8.GetString(data);
                    Console.WriteLine($"{string.Join(",", data)}");
                    Console.WriteLine(text);

                    data = new byte[5];
                }
                

            }
        }
    }
}
