

using CalculatorCommandPattern;
using CalculatorCommandPattern.Commands;

Calculator calculator = new Calculator();

while (true)
{
    Console.WriteLine($"Calculator -> {calculator.Current}");

    Console.Write("Operator: ");
    string operatorInput = Console.ReadLine();
    Console.Write("Operand: ");
    int operand = int.Parse(Console.ReadLine());
    ICommand command = null;
    switch (operatorInput)
    {
        case "+":
            command = new PlusCommand(operand);
            break;
        case "-":
            command = new MinusCommand(operand);
            break;
        case "*":
            command = new MultiplyCommand(operand);
            break;
        case "/":
            command = new DivideCommand(operand);
            break;
        case "cos":
            command = new CosCommand(operand);
            break;
        case "u":
            calculator.Undo(operand);
            break;
        case "r":
            calculator.Redo(operand);
            break;
        default:
            break;
    }
    if (command == null)
    {
        continue;
    }
    calculator.ExecuteCommand(command);
}