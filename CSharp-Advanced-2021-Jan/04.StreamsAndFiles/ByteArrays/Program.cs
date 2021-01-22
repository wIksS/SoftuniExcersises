using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ByteArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hubav tekst. AMa mnogo hubav. !";

            byte[] binaryText = Encoding.UTF8.GetBytes(text);

            Console.WriteLine(String.Join(" ", binaryText));
            
            using (FileStream writerStream = new FileStream($"../../../text.txt", FileMode.Create, FileAccess.Write))
            {
                writerStream.Write(binaryText, 0, binaryText.Length);
            }
        }
    }
}
