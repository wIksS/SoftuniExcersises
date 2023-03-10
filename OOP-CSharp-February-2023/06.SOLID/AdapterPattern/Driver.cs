using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Driver
    {

        public IEngine Engine { get; set; }

        public void Start()
        {
            Engine.StartEngine();
        }

        public void Stop()
        {
            Engine.StopEngine();
        }
    }
}
