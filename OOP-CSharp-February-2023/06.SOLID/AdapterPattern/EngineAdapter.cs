using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class EngineAdapter : IEngine
    {
        private ICar car;

        public EngineAdapter(ICar car)
        {
            this.car = car;
        }

        public void StartEngine()
        {
            car.StartEngine();
        }

        public void StopEngine()
        {
            car.StopEngine();
        }
    }
}
