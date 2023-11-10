using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    internal class Company
    {
        List<IWorker> workers;

        public void PaySalary()
        {
            foreach (var worker in workers)
            {
                if (worker is Robot)
                {
                    continue;
                }
            }
        }
    }
}
