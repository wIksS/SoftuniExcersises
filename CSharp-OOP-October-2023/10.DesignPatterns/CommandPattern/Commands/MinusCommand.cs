using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class MinusCommand : Command
    {
        public MinusCommand(decimal value) : base(value)
        {
            Operator = '-';
        }

        public override decimal Execute(decimal calculatorValue)
        {
            return calculatorValue - Value;
        }

        public override decimal UnExecute(decimal calculatorValue)
        {
            return calculatorValue + Value;
        }
    }
}
