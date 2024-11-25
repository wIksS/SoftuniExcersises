int n = int.Parse(Console.ReadLine());

try
{
    if (n % 2 == 0)
    {
        throw new ArgumentException();
    }

    Console.WriteLine("Odd");
}
catch (ArgumentException)
{
    Console.WriteLine("Even");
}