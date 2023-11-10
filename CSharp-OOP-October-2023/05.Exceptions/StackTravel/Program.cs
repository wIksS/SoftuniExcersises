try
{
    FirstMethod();

    void FirstMethod()
    {
        Console.WriteLine("Before FirstMethod");
        SecondMethod();

        Console.WriteLine("After FirstMethod");

    }

    void SecondMethod()
    {
        Console.WriteLine("Before SecondMethod");

        try
        {
            ThirdMethod();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Caught in Second method");
        }
        Console.WriteLine("After SecondMethod");

    }

    void ThirdMethod()
    {
        Console.WriteLine("Before ThirdMethod");

        FourthMethod();
        Console.WriteLine("After ThirdMethod");

    }

    void FourthMethod()
    {
        Console.WriteLine("Before FourthMethod");

        throw new NotImplementedException();
        Console.WriteLine("After FourthMethod");

    }

}
catch (Exception)
{

    throw;
}