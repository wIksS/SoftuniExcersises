RecursiveFor(4);

void RecursiveFor(int n)
{
    if (n <= 0)
    {
        return;
    }

    Console.WriteLine("Hello from recursion! (pre actions)");

    RecursiveFor(n - 1);

    Console.WriteLine("After recursion (post actions)");
}