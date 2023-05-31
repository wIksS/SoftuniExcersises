
// Print Hello 10 times

Print(10);

void Print(int times)
{
    if (times == 0)
    {
        return;
    }

    Console.WriteLine("Hello");

    Print(times - 1);
}