

Console.WriteLine("Enter a number between 1 and 10");
int number = 0;
try
{
    number = int.Parse(Console.ReadLine());

    if (number < 1 || number > 10)
    {
        throw new ArgumentOutOfRangeException("The number is not between 1 and 10");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.Message}");
    Console.WriteLine("Exception was thrown!!!");
    try
    {
        throw ex;
    }
    catch (Exception)
    {
        Console.WriteLine("Second throw catched");
    }
}

Console.WriteLine($"The number you entered is: {number}");