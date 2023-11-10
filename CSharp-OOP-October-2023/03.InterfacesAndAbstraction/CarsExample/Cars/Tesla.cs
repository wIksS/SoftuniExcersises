using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Cars
{
    internal class Tesla : ICar
    {
        public Battery Battery { get; set; }
        public void Accelerate(int force)
        {
            throw new NotImplementedException();
        }

        public void Decelerate(int force)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
