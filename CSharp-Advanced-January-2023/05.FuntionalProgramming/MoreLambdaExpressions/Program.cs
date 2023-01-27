


Action lambda2 = Hello;

lambda2();


Action lambda = () => Console.WriteLine("Hello");

static void Hello()
{
    Console.WriteLine("Hello from method");
}

Func<int> returnInt = () => 5 + 5;
Func<int> returnIntLong = () =>
{
    return 5 + 5;
};
Func<int> returnIntFromMethod = ReturnInt;

Console.WriteLine(returnInt());
Console.WriteLine(returnIntLong());
Console.WriteLine(returnIntFromMethod());

static int ReturnInt()
{
    return 5 + 5;
}

var promotion = (string promotion, int cash, string nameOfStore) =>
{
    if (promotion == "Tuesday")
    {
        return 20;
    }

    return 5;
};

Console.WriteLine(promotion("Tuesday", 100, "Ne znam")); 