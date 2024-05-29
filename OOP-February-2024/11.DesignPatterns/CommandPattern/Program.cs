

using CommandPattern;
using CommandPattern.Commands;

Calculator calculator = new Calculator();

while (true)
{
    calculator.PrintHistory();

    string @operator = Console.ReadLine();  
    int value = int.Parse(Console.ReadLine());

    ICommand command = null;
    if (@operator == "+")
    {
        command = new PlusCommand(value);
    }
    if (@operator == "-")
    {
        command = new MinusCommand(value);
    }
    if (@operator == "*")
    {
        command = new MultiplyCommand(value);
    }
    if (@operator == "/")
    {
        command = new DivideCommand(value);
    }
    if (@operator == "u")
    {
        calculator.Undo(value);
    }
    if (@operator == "r")
    {
        calculator.Redo(value);
    }
    if (command != null)
    {
        calculator.ExecuteCommand(command);
    }

    Console.Clear();
}