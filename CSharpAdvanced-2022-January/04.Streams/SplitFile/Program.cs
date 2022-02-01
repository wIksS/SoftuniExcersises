using System;
using System.IO;

namespace SplitFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int bytes = 1;
            Console.WriteLine("How many parts do you want?");
            int n = int.Parse(Console.ReadLine());
            using (FileStream stream = new FileStream(@"C:\Users\Viktor\source\repos\04.Streams\04.Streams\bin\Debug\netcoreapp3.1\..\..\..\text.txt", FileMode.Open))
            {
                long fileLength = (long)stream.Length / n;

                for (int i = 0; i < n; i++)
                {
                    int readBytes = 0;
                    using (FileStream newFile = new FileStream($"../../../text{i}.txt", FileMode.Create))
                    {
                        while (readBytes + bytes <= fileLength)
                        {
                            var data = new byte[bytes];
                            stream.Read(data, 0, data.Length);

                            newFile.Write(data, 0, data.Length);
                            readBytes += data.Length;
                        }

                    }
                }
            }
        }
    }
}
