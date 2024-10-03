
EncryptImage("../../../Images/1456237268.jpg");

void EncryptImage(string imagePath)
{
    using (FileStream fileStream = new FileStream(imagePath, FileMode.OpenOrCreate))
    {
        byte[] buffer = new byte[fileStream.Length];

        fileStream.Read(buffer, 0, buffer.Length);

        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (byte)(buffer[i] ^ 83);
        }

        fileStream.Seek(0, SeekOrigin.Begin);
        fileStream.Write(buffer,0,buffer.Length);
    }
}