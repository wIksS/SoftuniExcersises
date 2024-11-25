using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Doing the job");
        }
    }
}
