using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExample
{
    public interface IDrivable
    {
        public void Start();

        public void Break();

        public void Accelerate();
    }
}
