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
            using (StreamWriter writer= new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{GetFolderSize(new DirectoryInfo(folderPath),0) / 1024.0} KB");
            }
        }

        public static long GetFolderSize(DirectoryInfo folder, int level)
        {
            //Console.WriteLine($"{new string(' ', level * 3)}{folder.Name}");
            long bytes = 0;

            FileInfo[] files = folder.GetFiles();

            foreach (var file in files)
            {
                bytes += file.Length;
                //Console.WriteLine($"{new string(' ', level * 3)}{file.Name}");

            }

            DirectoryInfo[] subDirs = folder.GetDirectories();

            foreach (var subDir in subDirs)
            {
                bytes += GetFolderSize(new DirectoryInfo(subDir.FullName), level + 1);
            }

            return bytes;
        }
    }
}
