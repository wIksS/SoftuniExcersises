using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtriticalMethods
{
    public class HTTPRequester
    {
        [Critical(Severity =Severity.Critical, Message = "If this doesn't work we go out of business")]
        public void POST()
        {

        }
    }
}
