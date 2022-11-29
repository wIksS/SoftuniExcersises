using CommandCalculator.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandCalculator
{
    internal class Calculator
    {
        private List<ICommand> commands = new List<ICommand>();
        private int index = -1;
        public decimal Value { get; set; }

        public void Operation(char sign, int operand)
        {
            ICommand command = null;
            switch (sign)
            {
                case '+': command = new PlusCommand(operand); break;
                case '-': command = new MinusCommand(operand); break;
                case '/': command = new DivideCommand(operand); break;
                default:
                    break;
            }

            Value = command.Execute(Value);
            commands.Add(command);
            index++;
        }

        public void Undo()
        {
            if (commands.Count == 0)
            {
                return;
            }
            var command = commands[index];
            Value = command.UnExecute(Value);
            index--;
        }

        public void Redo()
        {
            index++;
            var command = commands[index];
            Value = command.Execute(Value);
        }

        public void Print()
        {
            for (int i = 0; i <= index; i++)
            {
                Console.Write($"{commands[i]} -> ");
            }
 
            Console.WriteLine(Value);
        }

    }
}
