
Greeting("Dimitrichko");

Console.WriteLine("Greeting again:");

Greeting("Goshko");

for (int i = 0; i < 4; i++)
{
    Greeting("Viktor");
}


void Greeting(string name)
{
    Console.WriteLine("Hello");
    Console.WriteLine($"My name is {name}");
    Console.WriteLine("And I study in SoftUni");
}