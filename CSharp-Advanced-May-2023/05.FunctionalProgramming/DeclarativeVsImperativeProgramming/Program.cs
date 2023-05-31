
// read a n from the console
// print numbers 1..n

// imperative programming

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(i + 1);
}


// declarative programming

PrintNumbers(ReadANumber());

int ReadANumber()
{
    return int.Parse(Console.ReadLine());
}

void PrintNumbers(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(i + 1);
    }
}