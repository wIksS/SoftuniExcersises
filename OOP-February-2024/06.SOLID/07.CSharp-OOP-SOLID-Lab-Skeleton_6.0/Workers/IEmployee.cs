using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal interface IEmployee : IWorker
    {
        public void PaySalary();

        public void GiveVouchers();

        public int Salary { get; set; }
    }
}
