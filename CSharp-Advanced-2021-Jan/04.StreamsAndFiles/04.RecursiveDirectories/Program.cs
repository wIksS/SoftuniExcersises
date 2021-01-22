using System;
using System.IO;

namespace _04.RecursiveDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Console.ReadLine();
            Console.WriteLine(ScanFolderRecursively(folderPath, 0));
        }

        static double ScanFolderRecursively(string folderPath, int identation)
        {
            double fileSizes = 0;

            try
            {
                var files = Directory.GetFiles(folderPath);



                var directories = Directory.GetDirectories(folderPath);
                foreach (var directory in directories)
                {
                    fileSizes += ScanFolderRecursively(directory, identation + 4);
                }

                foreach (var filePath in files)
                {
                    FileInfo file = new FileInfo(filePath);

                    // Console.WriteLine($"{new string(' ', identation)}{file.FullName}");

                    fileSizes += file.Length;
                }
            }
            catch (Exception)
            {

                ;
            }
            return fileSizes / 1024.0/ 1024.0;
        }
    }
}
