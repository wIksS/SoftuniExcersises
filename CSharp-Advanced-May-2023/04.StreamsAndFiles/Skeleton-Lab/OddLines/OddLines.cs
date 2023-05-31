namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int row = 0;
                    string line = "";
                    while (!reader.EndOfStream)
                    {
                        line=reader.ReadLine();
                        if (row++ % 2 == 0)
                        {
                            continue;
                        }

                        writer.WriteLine(line);
                    }
                }
            }
        }
    }
}
