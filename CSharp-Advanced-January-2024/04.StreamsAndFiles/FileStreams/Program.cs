

using System.Text;




string text = "Кирилица";
var fileStream =
 new FileStream("../../../log.txt", FileMode.Create);
using (fileStream)
{
    byte[] bytes = Encoding.UTF8.GetBytes(text);
    fileStream.Write(bytes, 0, bytes.Length);
}


using (FileStream stream = new FileStream("../../../input.txt", FileMode.Open))
{
    byte[] buffer = new byte[20];

    while (stream.Position < stream.Length)
    {       
        stream.Read(buffer, 0, buffer.Length);

        string input = Encoding.UTF8.GetString(buffer);

       // Console.WriteLine(string.Join(",", buffer));
        Console.Write(input);
        Thread.Sleep(300);
    }

}