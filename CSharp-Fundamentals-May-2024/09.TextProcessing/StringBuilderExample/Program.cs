

using System.Text;

string str = "hello";

StringBuilder sb = new StringBuilder();

sb.AppendLine("hello");

sb.AppendLine("add more");

sb.AppendLine("added even more");

sb.Insert(1, "***");

Console.WriteLine(sb);

string sbAsString = sb.ToString();