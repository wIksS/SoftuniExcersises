
StreamReader reader = null;
try
{
    reader = new StreamReader("../../../test.txt");

    int.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("OOPS error!");
    throw ex;
}
finally
{
    Console.WriteLine("This always executes");
    reader.Close();
}
