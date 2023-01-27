
int result = 0;

while (true)
{
    Console.WriteLine("Operation:");
    string operatorType = Console.ReadLine();

    Console.WriteLine("Value: ");
    int operand = int.Parse(Console.ReadLine());

    Func<int,int,int> operation = GetOperation(operatorType);

    result = Calculate(operation, result, operand);

    Console.WriteLine(result);
}

int Add(int x, int y)
{
    return x + y;
}
Func<int, int, int> GetOperation(string operatorType)
{
    switch (operatorType)
    {
        case "+": return Add;//(x, y) => x + y;
        case "-": return (x, y) => x - y;
        case "/": return (x, y) => x / y;
        case "*": return (x, y) => x * y;
        default:
            break;
    }

    return null;
}

int Calculate(Func<int,int,int> operation, int value, int operand)
{
    Console.WriteLine($"Performing operation for {value} and {operand}");
    return operation(value, operand);
}