
Action<int> printVar = Print;

printVar(5);

void Print(int x)
{
    Console.WriteLine("Hello" + x);
}