

using System.Net.Sockets;
using System.Text;

string text = "Hello";

byte[] bytes = Encoding.ASCII.GetBytes(text);

Console.WriteLine(string.Join(" ", bytes));

StreamReader sr;