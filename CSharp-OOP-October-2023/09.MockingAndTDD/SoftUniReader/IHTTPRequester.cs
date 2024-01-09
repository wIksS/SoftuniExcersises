using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniReader
{
    public interface IHTTPRequester
    {
        public string GetData(string url);
    }
}
