using System;
using System.Collections.Generic;
using System.Text;

namespace CommandCalculator.Commands
{
    internal class PlusCommand : Command
    {
        public PlusCommand(decimal operand) : base(operand)
        {

        }
        public override decimal Execute(decimal currentValue)
        {
            return currentValue + operand;
        }

        public override decimal UnExecute(decimal currentValue)
        {
            return currentValue - operand;
        }
    }
}
