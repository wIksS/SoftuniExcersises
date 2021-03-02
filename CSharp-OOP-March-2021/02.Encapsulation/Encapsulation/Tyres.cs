using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Tyres
    {
        private int kilometers;

        public int Threshhold { get; set; }
        public int KM { get; set; }

        public void Drive(int km)
        {
            kilometers += km;
        }

        public bool IsRubbish()
        {
            if (kilometers >= 20000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
