using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public interface ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public string Start();

        public string Stop();
    }
}
