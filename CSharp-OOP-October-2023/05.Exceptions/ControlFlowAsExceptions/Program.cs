
Console.WriteLine("Promotion today is: ");

// big no go zone
try
{
    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
    {
        throw new Exception();
    }

    Console.WriteLine("0%");
}
catch (Exception)
{
    Console.WriteLine("20%");
}