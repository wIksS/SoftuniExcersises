
using System.IO;
using System.Text;

Console.WriteLine(ReadFromStream(new FileStream("../../../Program.cs", FileMode.Open)));

string ReadFromStream<T>(T stream) where T : Stream
{
    byte[] buffer;
    using (stream)
    {
        buffer = new byte[stream.Length];

        stream.Read(buffer, 0, buffer.Length);

        Console.WriteLine(String.Join(",", buffer));
    }

    return Encoding.UTF8.GetString(buffer);
}