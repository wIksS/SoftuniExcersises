using System;
using System.IO;

namespace SplitFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parts = 31;
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.Open))
            {
                long sizeOfPart = stream.Length / parts;

                for (int i = 0; i < parts; i++)
                {
                    using (FileStream partStream = new FileStream($"../../../input{i + 1}.txt", FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[sizeOfPart];
                        stream.Read(buffer, 0, (int)sizeOfPart);

                        partStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
