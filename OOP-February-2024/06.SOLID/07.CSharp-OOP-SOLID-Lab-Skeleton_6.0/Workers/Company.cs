using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class Company
    {
        List<IEmployee> employee;
        List<IWorker> workers;

        public void Work()
        {
            foreach (IWorker worker in workers)
            {
                worker.Work();
            }
        }

        public void PaySalary()
        {
            foreach (var worker in employee)
            {
                worker.PaySalary();
            }
        }

        public void PayVourchers()
        {
            foreach (IEmployee worker in employee)
            {
                //if (worker is Robot)
                //{
                //    continue;
                //}
                //if (worker is Contractor)
                //{
                //    continue;
                //}
                worker.PaySalary();
            }
        }
    }
}
