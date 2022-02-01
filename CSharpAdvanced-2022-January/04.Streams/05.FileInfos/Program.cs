using System;
using System.IO;

namespace _05.FileInfos
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirPath = Console.ReadLine();

            Console.WriteLine($"Size in kbbytes: {ReadDirectory(dirPath, 0)/1024}");
        }

        public static long ReadDirectory(string path, int level)
        {
            long byteLength = 0;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            FileInfo[] files = dirInfo.GetFiles();
            Console.WriteLine($"{new string(' ', level * 3)} {dirInfo.Name}");

            string[] subDirs = Directory.GetDirectories(path);
            foreach (var subDir in subDirs)
            {
                byteLength +=ReadDirectory(subDir, level + 1);
            }

            foreach (var file in files)
            {
                Console.WriteLine($"{new string(' ', (level+1) * 3)} {file.Name}");
                byteLength += file.Length;
            }

            return byteLength;
        }
    }
}
