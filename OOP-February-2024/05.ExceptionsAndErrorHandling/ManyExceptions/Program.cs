bool isSuccess = false;
while (!isSuccess)
{
    try
    {
        Console.WriteLine("What is your age?");

        int age = int.Parse(Console.ReadLine());

        ArgumentException ageException = new ArgumentException("Your age cannot be less than zero :(");


        if (age < 0)
        {
            throw ageException;
        }

        Console.WriteLine(age + 10);
        isSuccess = true;

    }

    catch (FormatException)
    {
        Console.WriteLine("Ne mojesh da napishesh edno chislo :(");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Po golqmo ot int!!");
    }
    catch (ArithmeticException)
    {
        Console.WriteLine("Ne mojesh da napishesh edno chislo :(");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("");
    }
}