
// iterative
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Zdraveite");
//}

Print(10);

static void Print(int times)
{
    // base case
    if (times < 0)
    {
        return;
    }

    Console.WriteLine($"{times} Zdraveite");

    Print(times - 1);
}