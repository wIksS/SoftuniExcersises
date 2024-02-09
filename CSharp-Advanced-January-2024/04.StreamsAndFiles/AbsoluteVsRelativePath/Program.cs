
Console.WriteLine("Hello");
using (StreamReader reader = new StreamReader("../../../input.txt")) // absolute path
{
    Console.WriteLine(reader.ReadToEnd());
}



using (StreamWriter writer = new StreamWriter("../../../output.txt",true))
{
    writer.WriteLine("Hello from C#");
}
// relative