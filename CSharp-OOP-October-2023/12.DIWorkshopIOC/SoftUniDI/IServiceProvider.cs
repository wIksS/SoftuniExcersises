using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI
{
    public interface IServiceProvider
    {
        public T GetRequiredService<T>();
        public object GetRequiredService(Type type);
    }
}
