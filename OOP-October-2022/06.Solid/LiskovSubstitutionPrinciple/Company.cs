using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    internal class Company
    {
        List<IWorker> workers;
        List<IEmployee> employees;
        public Company(List<IWorker> workers, List<IEmployee> employees)
        {
            this.workers = workers;
            this.employees = employees;
        }

        public void ManageWorkers()
        {
            foreach (IEmployee employee in employees)
            {
                employee.GetSalary();
                employee.Sleep();
            }
            foreach (IWorker worker in workers)
            {
                worker.Work();

                //bad!!!
                //if (!(worker is Robot))
                //{
                //    worker.GetSalary();
                //    worker.Sleep();
                //}
            }
        }
    }
}
