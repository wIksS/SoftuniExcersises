using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern.Commands
{
    public class MinusCommand : Command
    {
        public MinusCommand(decimal value) : base('-', value)
        {
        }

        public override decimal Execute(decimal currentValue)
        {
            return currentValue - Value;
        }

        public override decimal Unexecute(decimal currentValue)
        {
            return currentValue + Value;
        }
    }
}
