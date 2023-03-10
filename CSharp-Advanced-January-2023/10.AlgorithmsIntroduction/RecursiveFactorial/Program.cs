

// n! = 1 * 2 * 3 .. * n
// 5! = 1 * 2 * 3 *4 * 5 = 120

// 5! = 5 * 4 * 3 * 2 * 1
// 4! = 4 * 3 * 2 * 1
// 4! = 4 * Factorial(3)
// 5! = 5 * Factorial(4)

//1! = 1
// 2! = 2 * Factorial(1)

Console.WriteLine(Factorial(int.Parse(Console.ReadLine())));

static long Factorial(int n)
{
    if (n == 1)
    {
        return 1;
    }

    //long nMinus1Factorial = ;

    return n * Factorial(n - 1);
}