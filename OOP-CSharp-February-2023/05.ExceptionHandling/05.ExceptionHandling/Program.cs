int number = 0;
try
{
    Console.WriteLine("Before read");
     number = int.Parse(Console.ReadLine());
}
catch (FormatException exception)
{
    Console.WriteLine("Tova ne chislo");
}

try
{
    Console.WriteLine(5 / number);
}
catch (DivideByZeroException exception)
{
    Console.WriteLine("Learn Math and then divide!");
}

Console.WriteLine("After Exception");
