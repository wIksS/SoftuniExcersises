using _12.DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop
{
    public class PastDateProvider : IDateProvider
    {
        public DateTime GetDate()
        {
            return DateTime.Now.AddYears(-1);
        }
    }
}
