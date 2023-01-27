Func<int> pointerToFunction = ReturnAnswerOfEverything;

int result = pointerToFunction();


Func<int, int, string, int> multiply = Multiply;

Console.WriteLine(multiply(5,5,"test"));

static int Multiply(int a, int b, string text)
{
    return a * b;
}

static int ReturnAnswerOfEverything()
{
    return 42;
}







static int Operation(int a, int b, Func<int,int,int> operation)
{
    Console.WriteLine("Performing operation");
    return operation(a, b);
}