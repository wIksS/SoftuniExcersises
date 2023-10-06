

using (StreamReader reader = new StreamReader(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-Advanced-September-2023\04.FilesAndStreams\01.ReadEachLine\input.txt"))
{
    string line = reader.ReadLine();
    int lineNumber = 1;
    while (line != null)
    {
        Console.WriteLine($"{lineNumber++}. {line}");
        line = reader.ReadLine();
    }
}