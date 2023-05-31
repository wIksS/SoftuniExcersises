
//Console.WriteLine(5);

//Console.WriteLine((5 ^ 183) ^ 183);

//Console.WriteLine(178 ^183);

foreach (var file in Directory.GetFiles("../../../Images"))
{
    EncryptDecryptImage(file);

}

void EncryptDecryptImage(string path)
{

    string basePath = "../../../Images/";
    using (FileStream read = new FileStream(path, FileMode.Open))
    {
        using (FileStream write = new FileStream($"{path}[e]", FileMode.Create))
        {
            byte[] buffer = new byte[1024];
            while (read.Read(buffer, 0, buffer.Length) > 0)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] ^= 157;
                }

                write.Write(buffer, 0, buffer.Length);
            }
        }
    }
}