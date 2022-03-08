using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public interface ICar
    {
       string Model { get; set; }
       string Color { get; set; }

        string Start();

        string Stop();           
    }
}
