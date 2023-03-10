

try
{
    Console.WriteLine("Before first");

    try
    {
        throw new ArgumentException("First ex");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("catched first ex");
    }

    Console.WriteLine("AFter first");

    throw new ArgumentException("Second ex");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    //throw ex;
}

Console.WriteLine("after try catch");

try
{

}
catch (Exception)
{

    throw;
}