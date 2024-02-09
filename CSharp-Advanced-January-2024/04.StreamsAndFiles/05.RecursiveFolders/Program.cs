


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
            long size = ReadFolder(folderPath);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{size / 1024.0}kb");
            }
        }

        public static long ReadFolder(string folderPath, int levels = 0)
        {
            string[] files = Directory.GetFiles(folderPath);
            long size = 0;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                size += fileInfo.Length;
                // Console.WriteLine($"{new string(' ', levels *3)}{fileInfo.Name}");
            }

            string[] directories = Directory.GetDirectories(folderPath);

            foreach (var dir in directories)
            {
                //Console.WriteLine($"{new string(' ', levels * 3)}{dir}");
                size += ReadFolder(dir, levels + 1);
            }

            return size;
        }
    }
}


