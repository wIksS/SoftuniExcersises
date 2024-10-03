

namespace OddLines
{
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
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    int line = 0;
                    string text = reader.ReadLine();
                    do
                    {
                        if (line++ % 2 == 1)
                        {
                            writer.WriteLine(text);
                        }
                        text = reader.ReadLine();
                    } while (text != null);
                }
            }
        }
    }

}


