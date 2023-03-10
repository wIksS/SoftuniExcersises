

try
{
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);  
}
finally
{
    Console.WriteLine("This code will always be executed");
}

using (StreamReader readerInUsing = new StreamReader(""))
{
    readerInUsing.ReadLine();
}

StreamReader reader = new StreamReader("");

try
{
    reader.ReadLine();
    throw new ArgumentException();
}
finally
{
    reader.Close();
}