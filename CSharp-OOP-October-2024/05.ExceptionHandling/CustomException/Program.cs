// See https://aka.ms/new-console-template for more information
using CustomException;

Console.WriteLine("Hello, World!");


try
{
    InvalidAgeException ex = new InvalidAgeException("Izlyga! Ne si tolkova mlad!")
    { Name = "Goshko" };
    throw ex;
}
catch (InvalidAgeException ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine($"{ex.Name} ne e na tolkova");
    //throw ex;
}