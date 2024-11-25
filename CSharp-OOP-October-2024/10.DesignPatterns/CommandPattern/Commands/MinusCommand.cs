﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class MinusCommand : Command
    {
        public MinusCommand(decimal parameter) : base('-', parameter)
        {
        }

        public override decimal ExecuteCommand(decimal currentResult)
        {
            return currentResult - Parameter;
        }

        public override decimal UndoCommand(decimal currentResult)
        {
            return currentResult + Parameter;
        }
    }
}
