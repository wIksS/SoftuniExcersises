using (StreamReader reader = new StreamReader("../../../input.txt"))
{
    while (!reader.EndOfStream)
    {
        Console.WriteLine(reader.ReadLine());
        Console.WriteLine(reader.EndOfStream);
    }
}