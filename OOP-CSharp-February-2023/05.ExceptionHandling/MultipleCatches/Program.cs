

try
{
    int age = int.Parse(Console.ReadLine());
    if (age < 0)
    {
        throw new ArgumentException("Age cannot be negative");
    }

    throw new InvalidOperationException();
}

catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Tova ne e chislo!!!!");
}
catch (OverflowException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Tova e tvyrde golqmo chislo");
}
catch (ArgumentException)
{
    //Console.WriteLine(ex.Message);
    Console.WriteLine("Kak taka otricatelni?");
}
catch (Exception)
{
    Console.WriteLine("Catching all");
}