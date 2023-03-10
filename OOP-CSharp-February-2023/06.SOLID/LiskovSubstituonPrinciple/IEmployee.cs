using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstituonPrinciple
{
    interface IEmployee
    {
        void Work();

        void Sleep();

        void GetSalary();
    }
}
