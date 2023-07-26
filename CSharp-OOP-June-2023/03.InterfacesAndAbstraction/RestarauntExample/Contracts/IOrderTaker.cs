using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntExample.Contracts
{
    public interface IOrderTaker
    {
        public void TakeOrder(string order);
    }
}
