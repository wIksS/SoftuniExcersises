Console.WriteLine("Enter a number between 1 and 10");
int number = 0;

try
{
    // The number five
    number = int.Parse(Console.ReadLine());

    if (number < 0 || number > 10)
    {
        throw new ArgumentOutOfRangeException("The number is not between 1 and 10");
    }

    Console.WriteLine($"100 / {number} = {100/number}");
    StackOverflowException ex = new StackOverflowException();
    ex.Data["reason"] = "No idea";
    throw ex;
}

catch (FormatException)
{
    Console.WriteLine("The input you entered is not a number");
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("The number should be between 1 and 10");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("You are trying to divide by zero");
}
catch (Exception e)
{
    StackOverflowException overflow = (StackOverflowException)e;
    Console.WriteLine(e.Data["reason"]);
    Console.WriteLine("Catching all other excs");
}