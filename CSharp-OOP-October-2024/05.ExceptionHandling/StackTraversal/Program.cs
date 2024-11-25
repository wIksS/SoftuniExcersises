try
{
    MethodOne();
}
catch (Exception)
{
    Console.WriteLine("Catch");
}

Console.WriteLine("After methods");

void MethodOne()
{
    Console.WriteLine("Before MethodOne");
    MethodTwo();
    Console.WriteLine("After MethodOne");

}

void MethodTwo()
{
    Console.WriteLine("Before MethodTwo");
    MethodThree();
    Console.WriteLine("After MethodTwo");
}

void MethodThree()
{
    Console.WriteLine("Before MethodThree");

    throw new ArgumentException();

    Console.WriteLine("After MethodThree");
}