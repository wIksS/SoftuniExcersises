

StreamReader reader = new StreamReader(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-Advanced-January-2024\04.StreamsAndFiles\StreamReaderDemo\Program.cs");

int lineNumber = 1;
while (!reader.EndOfStream)
{
    string line = reader.ReadLine();

    Console.WriteLine($"{lineNumber++}.{line}");
}

reader.Close();

using (StreamReader reader2 = new StreamReader(""))
{
    reader2.Dispose();
}

