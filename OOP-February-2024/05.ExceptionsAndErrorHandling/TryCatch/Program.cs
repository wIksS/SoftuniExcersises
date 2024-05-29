int diviser = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine($"1000/{diviser}={1000 / diviser}");
}
//catch (DivideByZeroException exception)
//{
//    Console.WriteLine("Why did you divide by zero? :/");
//    throw exception;
//}
finally
{
    Console.WriteLine("I always get here!!!");
}

Console.WriteLine("Did i get here?");
