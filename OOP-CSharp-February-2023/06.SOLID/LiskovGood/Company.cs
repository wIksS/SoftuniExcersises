using LiskovGood;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstituonPrinciple
{
    class Company
    {
        public List<ISalaryGetter> ISalaryGetters { get; set; }

        void GiveSalary()
        {
            foreach (var salaryGetter in ISalaryGetters)
            {
                salaryGetter.GetSalary();
            }
        }
    }
}
