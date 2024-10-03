
Func<int, string, double> functionInVariable = Square;

Console.WriteLine(functionInVariable);


double Square(int x, string message)
{
    Console.WriteLine(message);
    return x * x;
}