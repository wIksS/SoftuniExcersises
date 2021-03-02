using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Car
    {
        public Engine Engine { get; set; }

        public SpeedStats SpeedStats { get; set; }

        public Tyres Tyres { get; set; }

        public void Start()
        {
            Engine.Start();
            SpeedStats.StartWatching();
            if (Tyres.IsRubbish())
            {
                //Stats.Show("Change tyres");
            }
        }

        public void Stop()
        {
            Engine.Stop();
            SpeedStats.StopWatching();
            if (Tyres.IsRubbish())
            {
                //Stats.Show("Change tyres");
            }
        }

        public void PressPedal(long amount)
        {

        }
    }
}
