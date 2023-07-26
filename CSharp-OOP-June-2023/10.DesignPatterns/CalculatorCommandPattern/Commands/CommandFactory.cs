using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern.Commands
{
    public class CommandFactory
    {
        public static ICommand CreateCommand(string operation, decimal value)
        {
            if (operation == "+")
            {
                return new PlusCommand(value);   
            }
            if (operation == "-")
            {
                return new MinusCommand(value);
            }
            if (operation == "*")
            {
                return new MultiplyCommand(value);
            }
            if (operation == "/")
            {
                return new DivideCommand(value);
            }

            return null;
        }
    }
}
