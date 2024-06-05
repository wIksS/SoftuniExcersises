
PrintNameNTimes("Gosho", 10);
PrintNameNTimes("Niki", 2);


string name = Console.ReadLine();

PrintNameNTimes(name, int.Parse(Console.ReadLine()));

void PrintNameNTimes(string name, int times)
{
    for (int i = 0; i < times; i++)
    {
        PrintName(name);
    }
}

void PrintName(string firstName)
{
    Console.WriteLine($"Hello, my name is {firstName}");

}