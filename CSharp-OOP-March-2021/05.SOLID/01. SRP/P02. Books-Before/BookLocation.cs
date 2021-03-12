using System;
using System.Collections.Generic;
using System.Text;

namespace P02._Books_Before
{
    public class BookLocation
    {
        public Book Book { get; set; }

        public int Location { get; set; }

        public int TurnPage()
        {
            Location++;

            return Location;
        }
    }
}
