using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLiskov
{
    internal class ReadonlyDatabase : IReadDatabase
    {
        public Scoreboard Load()
        {
            return new Scoreboard();
        }
    }
}
