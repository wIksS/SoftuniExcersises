

using (StreamReader reader = new StreamReader(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-Advanced-September-2024\04.StreamsAndFiles\StreamReaderDemo\firstfile.txt"))
{
    //string firstLine = reader.ReadLine();
    //string secondLine = reader.ReadLine();

    string input = reader.ReadToEnd();

    Console.WriteLine(input);
}

string text = File.ReadAllText("../../../firstfile.txt");

Console.WriteLine(text);

//reader.Close();
//reader.Dispose();
//memory leak

//Console.WriteLine(firstLine);
//Console.WriteLine(secondLine);