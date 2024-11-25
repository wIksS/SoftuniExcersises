using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    abstract class Command
    {
        protected Command(char @operator, decimal parameter)
        {
            Operator = @operator;
            Parameter = parameter;
        }

        public char Operator { get; set; }
        public decimal Parameter { get; set; }
        public abstract decimal ExecuteCommand(decimal currentResult);
        public abstract decimal UndoCommand(decimal currentResult);
    }
}
