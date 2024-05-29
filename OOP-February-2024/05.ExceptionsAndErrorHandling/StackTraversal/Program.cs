Method1();

Console.WriteLine("Did i get here");


void Method1()
{
    Console.WriteLine("Before Method 1");
    Method2();
    Console.WriteLine("After Method 1");
}
void Method2()
{
    try
    {
        Console.WriteLine("Before Method 2");
        Method3();
    }
    catch (NotImplementedException ex)
    {
        Console.WriteLine("Caught");
        Console.WriteLine(ex.StackTrace);
    }

    Console.WriteLine("After Method 2");
}
void Method3()
{
    Console.WriteLine("Before Method 3");
    Method4();
    Console.WriteLine("After Method 3");
}
void Method4()
{
    Console.WriteLine("Before Method 4");
    Method5();
    Console.WriteLine("After Method 4");
}
void Method5()
{
    Console.WriteLine("Before Method 5");
    throw new NotImplementedException();
    Console.WriteLine("After Method 5");
}