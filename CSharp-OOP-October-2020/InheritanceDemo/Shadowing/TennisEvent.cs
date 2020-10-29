using System;
using System.Collections.Generic;
using System.Text;

namespace Shadowing
{
    class TennisEvent : Event
    {
        public DateTime Duration { get; set; }

        public void Start()
        {
            Console.WriteLine("Zagrqvka!");
            base.Start();
        }

        public override string ToString()
        {
            return base.ToString() + "Teniiiis";
        }

        public void PrintEvent()
        {
            string Duration = "X";
            this.Duration = DateTime.Now;
            base.Duration = 5;
        }
    }
}
