
using CommandPattern;
using CommandPattern.Commands;

Calculator calculator = new Calculator();


while (true)
{
    string @operator = Console.ReadLine();
    decimal parameter =Decimal.Parse(Console.ReadLine());

    Command command = null;

    switch (@operator)
    {
        case "+": 
            command = new PlusCommand(parameter); 
            break;
        case "-":
            command = new MinusCommand(parameter);
            break;
        case "*":
            command = new MultiplyCommand(parameter);
            break;
        case "/":
            command = new DivideCommand(parameter);
            break;
        case "u":
            calculator.Undo((int)parameter);
            break;
        case "r":
            calculator.Redo((int)parameter);
            break;
        default:
            break;
    }

    if (command != null)
    {
        calculator.ExecuteCommand(command);
    }

    Console.Clear();
    calculator.History();
}