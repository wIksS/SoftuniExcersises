using _12.DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop
{
    public class DateProvider : IDateProvider
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
