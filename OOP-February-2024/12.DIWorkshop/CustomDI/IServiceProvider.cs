using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDI
{
    public interface IServiceProvider
    {
        T GetService<T>();
    }
}
