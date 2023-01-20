namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer= new StreamWriter(outputFilePath))
                {
                    string line = reader.ReadLine();
                    int counter = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{counter++}. {line}");

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
