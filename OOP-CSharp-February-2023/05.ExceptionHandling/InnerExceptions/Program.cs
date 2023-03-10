
try
{
    throw new ArgumentException("First", new ArgumentException("Second", new ArgumentException("Third", new ArgumentException())));
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    throw;
}
