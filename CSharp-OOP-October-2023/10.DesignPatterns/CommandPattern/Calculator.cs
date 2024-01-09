using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Calculator
    {
        private List<Command> commands;

        public Calculator()
        {
            commands = new List<Command>();    
        }

        public decimal Value { get; set; }

        public void Execute(char operatorType, decimal value)
        {
            Command command = null;
            switch (operatorType)
            {
                case '+': command = new PlusCommand(value);
                    break;
                case '-':
                    command = new MinusCommand(value);
                    break;
                case '*':
                    command = new MultiplyCommand(value);
                    break;
                case '/':
                    command = new DivideCommand(value);
                    break;
                default:
                    break;
            }

            commands.Add(command);
            Value = command.Execute(Value);
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                var lastCommand = commands[commands.Count - 1];
                commands.RemoveAt(commands.Count - 1);
                Value = lastCommand.UnExecute(Value);
            }
        }

        public override string ToString()
        {
            string result = "0 ";

            foreach (Command command in commands)
            {
                result += $"{command.Operator} {command.Value} ";
            }

            result += $"= {Value}";

            return result;
        }
    }
}
