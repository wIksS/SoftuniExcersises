using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    class MinusCommand : Command
    {
        public MinusCommand(decimal valueToChange) : base(valueToChange)
        { }

        public override decimal Execute(decimal value)
        {
            return value - ValueToChange;
        }

        public override decimal Unexecute(decimal value)
        {
            return value + ValueToChange;
        }
    }
}
