using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern.Commands
{
    public class Calculator
    {
        private List<ICommand> commands = new List<ICommand>();

        public decimal Result{ get; set; }

        public void Execute(ICommand command)
        {
            commands.Add(command);

            Result = command.Execute(Result);
        }

        public void Undo(int times)
        {
            for (int i = 0; i < times; i++)
            {
                if (commands.Count == 0)
                {
                    break;
                }

                var command = commands[commands.Count - 1];
                Result = command.Unexecute(Result);

                commands.Remove(command);
            }
        }

        public override string ToString()
        {
            string result = "0";

            foreach (ICommand command in commands)
            {
                result += command.ToString();
            }

            result += $" = {Result}";

            return result;
        }
    }
}
