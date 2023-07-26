using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Renderers
{
    public interface IRenderer
    {
        public void Write(string s);
        public void WriteLine(string s);
    }
}
