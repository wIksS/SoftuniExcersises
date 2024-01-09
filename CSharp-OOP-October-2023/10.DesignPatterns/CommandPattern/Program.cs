

using CommandPattern;

Calculator calculator = new Calculator();
Console.WriteLine("0");
while (true)
{
    string[] input = Console.ReadLine().Split();
    decimal value = decimal.Parse(input[1]);
    if (input[0][0] == 'u')
    {
        calculator.Undo((int)value);
    }
    else
    {
        calculator.Execute(input[0][0], value);
    }

    Console.Clear();
    Console.WriteLine(calculator);
}