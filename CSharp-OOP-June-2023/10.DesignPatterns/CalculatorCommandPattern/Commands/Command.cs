using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern.Commands
{
    public abstract class Command : ICommand
    {
        public Command(char operand, decimal value)
        {
            Operand = operand;
            Value = value;
        }

        public char Operand { get; set; }

        public decimal Value { get; set; }

        public abstract decimal Execute(decimal currentValue);

        public abstract decimal Unexecute(decimal currentValue);

        public override string ToString()
        {
            return $" {Operand} {Value}"; 
        }
    }
}
