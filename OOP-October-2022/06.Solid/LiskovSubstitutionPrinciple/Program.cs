using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IWorker worker = new Robot();

            //worker.Work();
            //worker.GetSalary();
            //worker.Sleep();
            TeamLead teamLead = new TeamLead();
            Company company = new Company(new List<IWorker>()
            {
                new Robot(),
                teamLead
            },
            new List<IEmployee>()
            {
                teamLead
            });

            company.ManageWorkers();
        }
    }
}
