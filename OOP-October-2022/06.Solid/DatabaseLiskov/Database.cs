using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLiskov
{
    internal class Database : IReadDatabase, ISaveDatabase
    {
        public Scoreboard Load()
        {
            Console.WriteLine("Loading");

            return new Scoreboard();
        }

        public void Save(Scoreboard score)
        {
            Console.WriteLine("Saving");
        }

    }
}
