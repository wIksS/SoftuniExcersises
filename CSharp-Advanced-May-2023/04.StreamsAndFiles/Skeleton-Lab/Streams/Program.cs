

using (FileStream stream = new FileStream("../../../1984.txt", FileMode.Open))
{
    Console.WriteLine($"Length - {stream.Length}");
    Console.WriteLine($"Position - {stream.Position}");

    while (stream.Position < stream.Length)
    {
        byte[] buffer = new byte[4];

        stream.Read(buffer, 0, buffer.Length);

        for (int i = 0; i < buffer.Length; i++)
        {
            Console.Write((char)buffer[i]);
        }
    }
}

Console.WriteLine((int)' ');