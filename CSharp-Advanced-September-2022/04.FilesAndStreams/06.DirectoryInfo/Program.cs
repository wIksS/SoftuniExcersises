using System;
using System.IO;

namespace _06.DirectoryInfo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long bytes = RecurseDirectory("../../../../../");

            Console.WriteLine(bytes/1024/1024 + "mb");
        }

        private static long RecurseDirectory(string path)
        {
            long length = 0;
            Console.WriteLine(path);

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                //Console.WriteLine(file);
                FileInfo fileInfo = new FileInfo(file);
                length += fileInfo.Length;
            }

            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                length += RecurseDirectory(dir);
            }

            return length;
        }
    }
}
