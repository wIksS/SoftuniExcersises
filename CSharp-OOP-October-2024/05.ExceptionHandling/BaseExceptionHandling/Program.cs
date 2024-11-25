

try
{
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine($"In 10 years you will be: {age + 10}");
}
catch (FormatException ex)
{
    Console.WriteLine("String is not a number");
}
catch (OverflowException ex)
{
    Console.WriteLine("Number too large");
}
catch (Exception ex)
{
    Console.WriteLine("Something wrong happened");
}