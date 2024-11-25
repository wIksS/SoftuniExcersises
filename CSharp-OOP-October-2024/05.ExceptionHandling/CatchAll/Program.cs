int n = 0;
Console.WriteLine(100/n);
try
{
    int age = int.Parse(null);

    Console.WriteLine($"In 10 years you will be: {age + 10}");
}
catch (FormatException)
{
    Console.WriteLine("format was wrong");
}
catch (Exception ex)
{
    Console.WriteLine($"Ex type: {ex.GetType().Name}");
    Console.WriteLine($"Wrong : {ex.Message}");
}