using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandPattern
{
    public interface ICommand
    {
        decimal Execute(decimal current);

        decimal UnExecute(decimal current);
    }
}
