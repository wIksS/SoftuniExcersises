

Console.WriteLine(RecursiveNFactorial(int.Parse(Console.ReadLine())));

int RecursiveNFactorial(int n)
{
    Console.WriteLine($"{n}! = {n} * {n - 1}!");

    if (n == 1)
    {
        return 1;
    }

    //Console.WriteLine("Before Recursion");

    int result = RecursiveNFactorial(n-1);

    Console.WriteLine($"{n}! = {n} * {result}");

    return n*result;

}