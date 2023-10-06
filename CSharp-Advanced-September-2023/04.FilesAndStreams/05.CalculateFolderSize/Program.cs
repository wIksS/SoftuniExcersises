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
            long size = CalculateForderSize(folderPath, 0);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{size / 1024.0} KB");
            }
        }

        public static long CalculateForderSize(string folderPath, int level)
        {
           // Console.WriteLine($"{new string(' ', level * 3)}{folderPath}");
            string[] files = Directory.GetFiles(folderPath);
            long bytes = 0;
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);

                //Console.WriteLine($"{new string(' ', level * 3)}{info.Name} - {info.Length} bytes");
                bytes += info.Length;
            }

            // bin
            // obj
            string[] directories = Directory.GetDirectories(folderPath);

            foreach (var directoryPath in directories)
            {
                bytes += CalculateForderSize(directoryPath, level + 1);
            }

            return bytes;
        }
    }
}




