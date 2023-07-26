

using CalculatorCommandPattern.Commands;

Calculator calculator = new Calculator();

while (true)
{
    Console.WriteLine(calculator);

    Console.WriteLine("Operation:");
    string operation = Console.ReadLine();
    Console.WriteLine("Value:");
    decimal value = decimal.Parse(Console.ReadLine());

    if (operation == "undo")
    {
        calculator.Undo((int)value);
        continue;
    }

    calculator.Execute(CommandFactory.CreateCommand(operation,value));

}