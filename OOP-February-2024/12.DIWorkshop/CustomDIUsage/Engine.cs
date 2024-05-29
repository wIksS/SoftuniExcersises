using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDIUsage
{
    class Engine
    {
        private IRandomGenerator randomGenerator;

        public Engine(IRandomGenerator randomGenerator)
        {
            this.randomGenerator = randomGenerator;
        }

        public void Something()
        {

        }
    }
}
