using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern.Commands
{
    public class Calculator
    {
        private Stack<ICommand> commands = new Stack<ICommand>();
        private Stack<ICommand> undoneCommands = new Stack<ICommand>();
        public decimal Current { get; set; }

        public void ExecuteCommand(ICommand command, bool clearUndone = true)
        {
            Current = command.Execute(Current);
            commands.Push(command);

            if (clearUndone)
            {
                undoneCommands = new Stack<ICommand>();
            }
        }
        public void UnExecuteCommand(ICommand command)
        {
            Current = command.UnExecute(Current);
        }

        public void Undo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (commands.Count==0 )
                {
                    return;
                }

                var command =commands.Pop();
                UnExecuteCommand(command);
                undoneCommands.Push(command); 
            }
        }

        public void Redo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (undoneCommands.Count == 0)
                {
                    return;
                }

                var command = undoneCommands.Pop();
                ExecuteCommand(command);
            }
        }
    }
}
