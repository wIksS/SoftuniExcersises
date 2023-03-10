
FirstMethod();

void FirstMethod()
{
    Console.WriteLine("Before SecondMethod");
    try
    {
        SecondMethod();
    }
    catch (Exception)
    {

        //throw;
    }
    Console.WriteLine("After SecondMethod");

}

void SecondMethod()
{
    Console.WriteLine("Before ThirdMethod");

    try
    {
        ThirdMethod();
    }
    catch (Exception)
    {

        throw;
    }

    Console.WriteLine("After ThirdMethod");

}

void ThirdMethod()
{
    try
    {
        throw new NotImplementedException();
    }
    catch (Exception)
    {
        throw;
    }
}