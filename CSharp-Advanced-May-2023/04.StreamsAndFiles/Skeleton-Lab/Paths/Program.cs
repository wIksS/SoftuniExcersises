
string escaping = "\\ne\\e\n\\e";
Console.WriteLine(escaping);

Console.WriteLine(Path.GetFullPath("."));

using (StreamReader reader = new StreamReader("../../../input.txt"))
{
    Console.WriteLine(reader.ReadToEnd());
}

Console.ReadLine();