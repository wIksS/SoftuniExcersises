using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        int Add(int a, int b);

        int Divide(int a, int b);

        void ClearHistory();
    }
}
