using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    public interface ICommand
    {
        public decimal Execute(decimal current);

        public decimal UnExecute(decimal current);

        public decimal Value { get; set; }

        public char Operator { get; set; }
    }
}
