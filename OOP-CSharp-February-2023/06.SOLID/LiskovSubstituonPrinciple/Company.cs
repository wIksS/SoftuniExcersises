using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstituonPrinciple
{
    class Company
    {
        public List<IEmployee> Employees { get; set; }

        void GiveSalary()
        {
            foreach (var employee in Employees)
            {
                if (employee is ChatRobot)
                {
                    continue;
                }

                employee.GetSalary();
            }
        }
    }
}
