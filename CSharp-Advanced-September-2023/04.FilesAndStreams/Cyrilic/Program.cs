

using System.Text;

byte[] data = Encoding.Unicode.GetBytes("Този стринг");

Console.WriteLine(string.Join(" ", data));

Console.WriteLine(Encoding.Unicode.GetString(data));