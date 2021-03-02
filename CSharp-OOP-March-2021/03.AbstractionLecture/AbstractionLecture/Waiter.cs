using AbstractionLecture.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLecture
{
    public class Waiter
    {
        public IOrderable Kitchen { get; set; }
    }
}
