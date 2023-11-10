using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Cars
{
    internal class Driver
    {
        private ICar car = new Tesla();

        public void DriveTo(string address)
        {
            car.Start();

            car.Accelerate(100);

            car.Stop();
        }
    }
}
