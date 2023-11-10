using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Cars
{
    internal interface ICar
    {
        public void Start();

        public void Stop();

        public void Accelerate(int force);

        public void Decelerate(int force);
    }
}
