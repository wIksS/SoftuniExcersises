namespace ExtractBytes
{
    using System.IO;

    public class ExtractBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";



            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (FileStream image = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (FileStream bytes = new FileStream(bytesFilePath, FileMode.Open))
                {
                    byte[] bytesBuffer = new byte[bytes.Length];

                    bytes.Read(bytesBuffer, 0, (int)bytes.Length);

                    byte[] imageBuffer = new byte[image.Length];

                    image.Read(imageBuffer, 0, (int)image.Length);

                    using (FileStream output = new FileStream(outputPath, FileMode.Create))
                    {
                        for (int i = 0; i < imageBuffer.Length; i++)
                        {
                            for (int j = 0; j < bytesBuffer.Length; j++)
                            {
                                if (imageBuffer[i] == bytesBuffer[j])
                                {
                                    output.Write(new byte[] { imageBuffer[i] });
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
