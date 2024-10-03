

using System.Text;

string text = "A hello";

byte[] buffer = Encoding.ASCII.GetBytes(text);

Console.WriteLine(string.Join(" ", buffer));