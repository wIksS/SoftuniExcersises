using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
   public interface IMoneyTransfer
    {
        void Transfer(string from, string to, decimal amount);
    }
}
