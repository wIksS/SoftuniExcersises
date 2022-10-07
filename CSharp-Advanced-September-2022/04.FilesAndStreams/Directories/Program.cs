using System;
using System.IO;

namespace Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\Users\Viktor\source\repos\04.FilesAndStreams\Directories\Losho");


            string[] files = Directory.GetFiles("../../../");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            string[] subDirs = Directory.GetDirectories("../../../");

            foreach (string directory in subDirs)
            {
                Console.WriteLine(directory);
            }

        }
    }
}
