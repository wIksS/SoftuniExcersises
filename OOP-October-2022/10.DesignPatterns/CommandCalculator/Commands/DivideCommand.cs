using System;
using System.Collections.Generic;
using System.Text;

namespace CommandCalculator.Commands
{
    internal class DivideCommand : Command
    {
        public DivideCommand(decimal operand) : base(operand)
        {

        }
        public override decimal Execute(decimal currentValue)
        {
            return currentValue / operand;
        }

        public override decimal UnExecute(decimal currentValue)
        {
            return currentValue * operand;
        }
    }
}
