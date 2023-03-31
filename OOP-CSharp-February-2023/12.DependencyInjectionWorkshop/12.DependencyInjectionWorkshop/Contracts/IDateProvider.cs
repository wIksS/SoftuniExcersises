using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Contracts
{
    public interface IDateProvider
    {
        DateTime GetDate();
    }
}
