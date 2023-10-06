

using System.Net.Sockets;
using System.Text;

//byte[] byteArray = new byte[3] { 255, 2, 3 };
//// 255
//string text = "ALorem ipsum dolor sit amet";
//byte[] data = Encoding.ASCII.GetBytes(text);

//Console.WriteLine(string.Join(" ", data));

using (FileStream stream = new FileStream("../../../input.txt", FileMode.OpenOrCreate))
{
    byte[] buffer = new byte[1000];
    Console.WriteLine($"Stream bytes: {stream.Length}");
    while (stream.Read(buffer, 0, buffer.Length) > 0)
    {
        Console.WriteLine("----------");
        string text = Encoding.UTF8.GetString(buffer);

        Console.WriteLine($"{text}   -> Position: {stream.Position}");
        Console.WriteLine("----------");

    }
}