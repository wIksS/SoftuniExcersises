using System;
using System.Collections.Generic;
using System.Text;

namespace CommandCalculator.Commands
{
    internal interface ICommand
    {
        decimal Execute(decimal value);

        decimal UnExecute(decimal value);
    }
}
