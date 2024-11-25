using System;
using System.Reflection.Metadata.Ecma335;

namespace P04.Recharge
{
    public class RechargeableStation : IStation
    {
        private int _capacity;
        private int _current;
        public RechargeableStation(int capacity)
        {
            this._capacity = capacity;
            this._current = 0;
        }

        public int Capacity 
        { 
            get => _capacity;
        }
        public int Current 
        { 
            get => _current;
        }

        public void Charge(IRechargeable rechargeable)
        {
            _current++;
            rechargeable.Recharge();
        }

        public void Dismount()
        {
            _current--;
        }
    }
}
