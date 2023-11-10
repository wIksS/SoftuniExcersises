
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Dimitrichko");
}

PrintRecursive(10);

void PrintRecursive(int times)
{
    if (times <= 0)
    {
        return;
    }

    Console.WriteLine("Dimitrichko from recursion");
    PrintRecursive(times - 1);
}