using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    public class TennisEvent : Event
    {
        public DateTime Duration { get; set; }

        public void Start()
        {
            Console.WriteLine("Zagrqvka!!!");
            base.Start();
        }

        public void Print()
        {
            string Duration = "X";
            Duration = "X";
            this.Duration = DateTime.Now;
            base.Duration = 5;
        }
    }
}
