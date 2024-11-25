

while (true)
{

    try
    {
        Console.WriteLine("How old are you?");

        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"In 10 years you will be: {age + 10}");

        break;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("You entered invalid age!");
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("You are too old! Be younger!");
    }

}
Console.WriteLine("After try catch!");