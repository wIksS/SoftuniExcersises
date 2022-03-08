using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface IElectricCar
    {
        int Battery { get; set; }

       string Start();
    }
}
