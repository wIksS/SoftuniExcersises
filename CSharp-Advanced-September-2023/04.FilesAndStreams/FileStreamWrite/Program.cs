
using System.Text;

string text = "Hello from the program to the file";
byte[] data = Encoding.ASCII.GetBytes(text);

using(FileStream stream = new FileStream("../../../input.txt", FileMode.Create))
{
    stream.Write(data,0,data.Length);
}