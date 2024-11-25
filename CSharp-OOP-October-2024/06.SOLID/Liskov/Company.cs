using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    internal class Company
    {
        public Company()
        {
            EmployedWorkers = new List<EmployedWorker>();
            Workers = new List<IWorker>();
        }
        public List<EmployedWorker> EmployedWorkers { get; set; }
        public List<IWorker> Workers{ get; set; }

        public void Work()
        {
            foreach (var worker in Workers)
            {
                worker.Work();
            }
        }

        public void TakeBreak()
        {
            foreach (var worker in EmployedWorkers)
            {
                //if (worker is Robot)
                //{

                //}
                worker.TakeBreak();
            }
        }
    }
}
