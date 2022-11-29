using System;
using System.Collections.Generic;
using System.Text;

namespace CommandCalculator.Commands
{
    internal abstract class Command : ICommand
    {
        protected decimal operand;

        public Command(decimal operand)
        {
            this.operand = operand;
        }
        public abstract decimal Execute(decimal value);

        public abstract decimal UnExecute(decimal value);

        public override string ToString()
        {
            return $"{operand}";
        }
    }
}
