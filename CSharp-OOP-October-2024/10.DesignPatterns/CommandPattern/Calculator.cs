using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Calculator
    {
        private List<Command> commands = new List<Command>();
        private List<Command> redoCommands = new List<Command>();

        public decimal Result { get; set; }

        public void ExecuteCommand(Command command, bool clearCache = true)
        {
            commands.Add(command);

            Result = command.ExecuteCommand(Result);
            if (clearCache)
            {
                redoCommands = new List<Command>();
            }
        }

        public void Undo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (commands.Count == 0)
                {
                    break;
                }

                Result = commands[commands.Count - 1].UndoCommand(Result);
                redoCommands.Add(commands[commands.Count-1]);

                commands.RemoveAt(commands.Count - 1);
            }
        }

        public void Redo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (redoCommands.Count == 0)
                {
                    break;
                }

                ExecuteCommand(redoCommands[redoCommands.Count-1], false);

                redoCommands.RemoveAt(redoCommands.Count - 1);
            }
        }

        public void History()
        {
            string result = "0";

            foreach (Command command in commands)
            {
                result += $" {command.Operator} {command.Parameter}";
            }

            result += " = " + Result;
            Console.WriteLine(result);
        }
    }
}
