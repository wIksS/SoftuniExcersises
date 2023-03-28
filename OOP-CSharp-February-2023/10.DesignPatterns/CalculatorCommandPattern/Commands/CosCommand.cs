using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern.Commands
{
    public class CosCommand : Command
    {
        private decimal oldValue;
        public CosCommand(int operand) : base(operand)
        {
        }

        public override decimal Execute(decimal current)
        {
            oldValue = current;
            return (decimal)Math.Cos(Decimal.ToDouble(current)); ;
        }

        public override decimal UnExecute(decimal current)
        {
            return oldValue;
        }
    }
}
