using System;
using System.IO;

namespace GetDirInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("../../../");

            foreach (string file in fileNames)
            {
                Console.WriteLine(file);
                FileInfo info = new FileInfo(file);
                Console.WriteLine(info.Name);
                Console.WriteLine(info.Extension);
                Console.WriteLine(info.Length);
            }

            string[] subDirectories = Directory.GetDirectories("../../../");

            foreach (var dirPath in subDirectories)
            {
                Console.WriteLine(dirPath);
                DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);

                Console.WriteLine(directoryInfo.Name);
            }
        }
    }
}
