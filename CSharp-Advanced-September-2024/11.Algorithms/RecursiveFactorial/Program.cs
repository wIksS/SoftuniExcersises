Console.WriteLine(Factorial(5));


int Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }

    Console.WriteLine($"Before {n}!");
    // n! = n * n-1!
    int nMinusOneFactorial = Factorial(n - 1);

    Console.WriteLine($"After {n}! and {n-1}!={nMinusOneFactorial}");


    return n * nMinusOneFactorial;
}