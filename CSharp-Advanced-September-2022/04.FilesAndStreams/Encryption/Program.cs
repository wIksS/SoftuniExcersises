using System;
using System.IO;
using System.Text;

namespace Encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(131 ^ 157);
            //Console.WriteLine(30 ^157);
            using (FileStream writeStream = new FileStream("../../../text.txt", FileMode.Create))
            {
                string text = "ABC";
                byte[] buffer = Encoding.ASCII.GetBytes(text);
                byte secret = 157;

                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] ^= secret;
                }

                writeStream.Write(buffer);
            }
            using (FileStream stream = new FileStream("../../../text.txt", FileMode.Open))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer);


                byte secret = 157;

                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] ^= secret;
                }

                string text = Encoding.ASCII.GetString(buffer);
                Console.WriteLine(text);
            }
        }

    }
}
