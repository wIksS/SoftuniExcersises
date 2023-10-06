
Console.WriteLine(Add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

Console.WriteLine(Add(5,6));
// impure function
int Add(int a, int b)
{
    if (new Random().Next() % 2 == 0)
    {
        b += 15;
    }

    return a + b;
}

//pure

int AddPure(int a, int b)
{
    if (a < 10)
    {
        return a;
    }
    if (a > 100)
    {
        return -42;
    }
    return a + b;
}