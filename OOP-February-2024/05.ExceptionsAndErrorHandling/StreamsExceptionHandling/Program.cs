StreamReader reader= null;

try
{
    reader = new StreamReader("../../../Program.cs");
    Console.WriteLine("reader.ReadLine());");

    throw new OutOfMemoryException();

}
finally
{
    Console.WriteLine("Closing reader");
    reader.Dispose();
}