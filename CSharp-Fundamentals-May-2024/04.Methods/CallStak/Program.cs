
Console.WriteLine("Before all Methods");

First();

Console.WriteLine("After all methods");

void First()
{
    Console.WriteLine("Begin First");
    Second();

    Console.WriteLine("End First");
}

void Second()
{
    Console.WriteLine("Begin Second");

    Third();
    Console.WriteLine("End Second");
}

void Third()
{
    Console.WriteLine("Ënd");
}