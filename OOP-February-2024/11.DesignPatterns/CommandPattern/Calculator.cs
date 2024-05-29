using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Calculator
    {
        private List<ICommand> commands;
        private List<ICommand> redoCommands;

        public Calculator()
        {
            commands = new List<ICommand>();
            redoCommands = new List<ICommand>();
        }

        public decimal Result { get; set; }

        public void ExecuteCommand(ICommand command)
        {
            Result = command.Execute(Result);
            commands.Add(command);
            redoCommands.Clear();
        }

        public void Undo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Result = commands[commands.Count - 1].UnExecute(Result);
                redoCommands.Add(commands[commands.Count - 1]);
                commands.RemoveAt(commands.Count - 1);
            }
        }


        public void Redo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Result = redoCommands[redoCommands.Count - 1].Execute(Result);
                commands.Add(redoCommands[redoCommands.Count - 1]);
                redoCommands.RemoveAt(redoCommands.Count - 1);
            }
        }
        public void PrintHistory()
        {
            Console.Write("0 ");
            foreach (var command in commands)
            {
                Console.Write($"{command.Operator} {command.Value} ");
            }

            Console.WriteLine(" = " + Result);
        }
    }
}
