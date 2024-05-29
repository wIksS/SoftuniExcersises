using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public class MultiplyCommand : ICommand
    {
        public MultiplyCommand(decimal value)
        {
            Value = value;
            Operator = '*';
        }

        public decimal Value { get; set; }
        public char Operator { get; set; }

        public decimal Execute(decimal current)
        {
            return current * Value;
        }

        public decimal UnExecute(decimal current)
        {
            return current / Value;
        }
    }
}
