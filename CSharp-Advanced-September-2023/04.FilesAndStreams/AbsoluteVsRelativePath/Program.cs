

// Absolute

string absolutePath = @"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-Advanced-September-2023\04.FilesAndStreams\AbsoluteVsRelativePath\input.txt";

// Relative

string relativePath = "../../../input.txt";

Console.WriteLine(Path.GetFullPath("."));

using (StreamReader reader = new StreamReader(absolutePath))
{
    Console.WriteLine(reader.ReadToEnd());
}

Console.ReadLine();