
EncryptFile("../../../1.jpg");

void EncryptFile(string fileName)
{
    using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
    {
        byte[] data = new byte[stream.Length];

        stream.Read(data, 0, data.Length);

        for (int i = 0; i < data.Length; i++)
        {
            data[i] = (byte)(data[i] ^ 177773);
        }

        stream.Seek(0, SeekOrigin.Begin);

        stream.Write(data, 0, data.Length);
        Console.WriteLine(data.Length);
       /// Console.WriteLine(string.Join(" ", data));

    }
}
