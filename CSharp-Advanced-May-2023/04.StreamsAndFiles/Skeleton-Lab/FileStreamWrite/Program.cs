

using System.Text;

using (FileStream stream = new FileStream("../../../generated.txt", FileMode.Create))
{
    string text = "Как се пише на кирилица?";
    byte[] buffer = Encoding.Unicode.GetBytes(text);
    stream.Write(buffer, 0, buffer.Length);
}


using (FileStream stream = new FileStream("../../../generated.txt", FileMode.Open))
{
    byte[] buffer = new byte[stream.Length];

    stream.Read(buffer, 0, buffer.Length);

    string text = Encoding.Unicode.GetString(buffer);

    Console.WriteLine(text);
}