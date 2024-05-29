using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    public interface IDriveable
    {
        void Accelerate();

        void Decelerate();

        void Start();

        void Stop();
    }
}
