

using CustomExceptions;
SoftUniException exS = new SoftUniException("Custom message");
exS.Course = "C# OOP";

try
{
    throw exS;
}
catch (SoftUniException ex)
{

    Console.WriteLine(ex.Course);
    Console.WriteLine(ex.Message);
}
