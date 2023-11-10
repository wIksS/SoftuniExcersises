using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySingleResponsbility.Services.Contracts
{
    internal interface ICompany
    {
        public void AddTenure(List<Employee> employees);

        public void PrintReport(List<Employee> employees);
        public void PayBonus(List<Employee> employees, decimal amount);

    }
}
