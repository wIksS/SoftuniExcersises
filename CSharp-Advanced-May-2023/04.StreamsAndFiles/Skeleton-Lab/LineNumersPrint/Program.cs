

using (StreamReader reader = new StreamReader("../../../input.txt"))
{
    int row = 1;

    while (!reader.EndOfStream)
    {
        Console.WriteLine($"{row++}. {reader.ReadLine()}");
    }
}