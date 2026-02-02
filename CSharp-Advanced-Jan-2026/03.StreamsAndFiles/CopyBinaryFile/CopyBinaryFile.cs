namespace CopyBinaryFile
{
    using System;
    using System.IO;
    using System.Text;

    public class CopyBinaryFile
    {
        static void Main()
        {
            //string inputFilePath = @"..\..\..\copyMe.png";
            string inputFilePath = @"..\..\..\text.txt";
            //string outputFilePath = @"..\..\..\copyMe-copy.png";
            string outputFilePath = @"..\..\..\txt-copy.txt";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void ClearFile(FileStream fileStream)
        {
            //int n = 5;
            //byte[] buffer = new byte[n];
            //int position = 0;
            //int readCount = fileStream.Read(buffer, 0, n);
            //while (readCount > 0)
            //{
            //    Console.WriteLine(fileStream.Position);
            //    fileStream.Seek(position, SeekOrigin.Begin);
            //    position += n;
            //    var empty = new byte[n];
            //    fileStream.Write(empty, 0, readCount);

            //    readCount = fileStream.Read(buffer, 0, n);
            //}
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open))
            {
                File.Delete(outputFilePath);

                using (FileStream outputStream = new FileStream(outputFilePath, FileMode.OpenOrCreate))
                {
                    outputStream.SetLength(inputStream.Length);

                    int n = 5;
                    byte[] buffer = new byte[n];
                    int readCount = inputStream.Read(buffer, 0, n);
                    while (readCount > 0)
                    {
                        string parsedBuffer = Encoding.ASCII.GetString(buffer);

                        //Console.WriteLine(String.Join(",", buffer));
                        //Console.WriteLine(parsedBuffer);

                        outputStream.Write(buffer, 0, readCount);
                        readCount = inputStream.Read(buffer, 0, n);
                    }
                }
            }
        }
    }
}
