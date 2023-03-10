using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Car : ICar
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }

        public void RePaint()
        {
            throw new NotImplementedException();
        }

        public void ServiceCheck()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
