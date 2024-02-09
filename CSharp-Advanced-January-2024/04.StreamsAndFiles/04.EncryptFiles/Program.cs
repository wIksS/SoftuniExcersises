
string folderPath = "./Images";

string[] files = Directory.GetFiles(folderPath);

foreach (string file in files)
{
    EncryptFile(file);
}

void EncryptFile(string filePath)
{

    using (FileStream stream = new FileStream(filePath,FileMode.Open))
    {
        byte[] data = new byte[stream.Length];

        stream.Read(data, 0, data.Length);

        for (int i = data.Length/2; i < data.Length; i++)
        {
            data[i] = (byte)(data[i] ^ 178);
        }

        stream.Seek(0, SeekOrigin.Begin);   
        stream.Write(data, 0, data.Length);
    }
}