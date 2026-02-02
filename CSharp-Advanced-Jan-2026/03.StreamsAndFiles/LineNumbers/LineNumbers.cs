namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            char[] punctuationMarks = ['!', '?', '-', ',', '\'', '"', ':', ';', '.'];

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int row = 1;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int lettersCount =  line.Count(c => Char.IsLetter(c));
                        int punctuationCount = line.Count(c => punctuationMarks.Contains(c));

                        writer.WriteLine($"Line {row}: {line} {lettersCount} {punctuationCount}");

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}

//for (int i = 0; i < line.Length; i++)
//{
//    if (Char.IsLetter(line[i]))
//    {
//        lettersCount++;
//    }
//    //if (Char.IsPunctuation(line[i]))
//    if (punctuationMarks.Contains(line[i]))
//    {
//        punctuationCount++;
//    }
//}