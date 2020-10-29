using System;
using System.Collections.Generic;
using System.Text;

namespace Shadowing
{
    class Event
    {
        public DateTime StartDate { get; set; }

        public int Duration { get; set; }

        public void Start()
        {
            Console.WriteLine("Event is starting!!!");
        }
    }
}
