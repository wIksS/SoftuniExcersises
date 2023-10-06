

StreamWriter disposble = new StreamWriter("");
disposble.Dispose();
using (disposble)
{

}



using (StreamReader reader = new StreamReader(@"C:\Users\Viktor\Desktop\Work\SoftuniExcersises\CSharp-Advanced-September-2023\04.FilesAndStreams\04.FilesAndStreams\2HelloWorldFromAFile.txt"))
{
    string content = reader.ReadToEnd();

    Console.WriteLine(content);
}

