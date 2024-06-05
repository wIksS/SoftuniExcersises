
int GetNumber()
{
    return 10;

    return 50;
}

string Greeting()
{

    return "Hello!";
}

int result = GetNumber() + 20 + GetNumber();
Console.WriteLine(result);

string greeting = Greeting() + Greeting() + Greeting();
string greeting2 = "Hello!" + "Hello!" + "Hello!";


Console.WriteLine(greeting);
Console.WriteLine(greeting2);
