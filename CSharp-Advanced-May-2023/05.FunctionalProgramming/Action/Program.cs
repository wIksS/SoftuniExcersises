

Action<float> printNumber = (float n) => Console.WriteLine(n);
printNumber(5);

Func<float, int, int[], DateTime, int> print = PrintEverything;

int PrintEverything(float n, int a, int[] arr, DateTime date)
{
    Console.WriteLine(n);
    return 5;
}