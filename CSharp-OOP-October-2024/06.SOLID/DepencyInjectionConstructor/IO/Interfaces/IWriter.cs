using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjectionConstructor.IO.Interfaces
{
    public interface IWriter
    {
        void Write(string msg);

        void WriteLine(string msg);
    }
}
