
namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write(GetFolderSize(folderPath) / 1000 / 1000.0 + " KB");
            }
        }

        public static long GetFolderSize(string path, int level = 0)
        {
            //Console.WriteLine($"{new string(' ', level * 3)}{path}");

            long size = 0;
            string[] files = Directory.GetFiles(path);
            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                size += file.Length;
                //Console.WriteLine($"{new string(' ', (level+1)*3)}{file.Name}");
            }

            string[] dirs = Directory.GetDirectories(path);
            foreach (var dirPath in dirs)
            {
                size += GetFolderSize(dirPath, level + 1);
            }

            return size;
        }
    }
}




