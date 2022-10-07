using System;
using System.IO;
using System.Text;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //using (FileStream writeStream = new FileStream("../../../text.txt", FileMode.Append))
            //{
            //    string input = Console.ReadLine();
            //    while (input != "end")
            //    {

            //        byte[] buffer = Encoding.ASCII.GetBytes(input + "\n");
            //        writeStream.Write(buffer);

            //        input = Console.ReadLine();
            //    }

            //}
            int bufferSize = 256;
            using (FileStream readStream = new FileStream("../../../text.txt", FileMode.Open))
            {
                byte[] buffer = new byte[16];
                readStream.Seek(5, SeekOrigin.Begin);

                while (readStream.Read(buffer) != 0)
                {
                    Console.WriteLine("Position of stream: " + readStream.Position);

                    //Console.WriteLine(readStream.Read(buffer)/1024/1024);

                    string text = Encoding.ASCII.GetString(buffer);
                    Console.WriteLine(text);
                    if (readStream.Position > 100)
                    {
                        readStream.Seek(0, SeekOrigin.Begin);
                    }
                }


                //Console.WriteLine(text);
            }
        }
    }
}
