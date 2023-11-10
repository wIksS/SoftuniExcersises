using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    public interface IHumanWorker : IWorker
    {

        public void GetSalary();

        public void Rest();
    }
}
