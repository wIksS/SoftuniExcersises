using System.IO;

public class LineNumbers
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\Files\input.txt";
        string outputFilePath = @"..\..\..\Files\output.txt";


        RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
    }

    public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
    {
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int index = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine($"{index + 1}. {line}");
                    index++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
