

//5! = 5 * 4!
//4! = 4 * 3!(3 * 2 * 1)
//...
// 1! = 1

Console.WriteLine(NFactorial(int.Parse(Console.ReadLine())));
long NFactorial(int n)
{
    if (n == 1)
    {
        return 1;
    }

    long nMinusOneFactorial = NFactorial(n - 1);

    return n * nMinusOneFactorial;
}


long NFactorialIterative(int n)
{
    long result = 1;

    for (int i = 1; i < n; i++)
    {
        result *= i;
    }

    return result;
}