namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long size = GetFolderSize(folderPath,0);

            File.WriteAllText(outputFilePath,$"{size/1024 } KB");
        }

        public static long GetFolderSize(string path, int level)
        {
            //Console.WriteLine($"{new string(' ', level * 3)}{new DirectoryInfo(path).Name}");
            string[] filePaths = Directory.GetFiles(path);

            long size = 0;

            foreach (var filePath in filePaths)
            {
                FileInfo info = new FileInfo(filePath);
                size += info.Length;
                //Console.WriteLine($"{new string(' ', (level + 1) * 3)}{info.Name}");
            }

            foreach (var dirPaths in Directory.GetDirectories(path))
            {
                size += GetFolderSize(dirPaths, level+1);
            }

            return size;
        }
    }
}
