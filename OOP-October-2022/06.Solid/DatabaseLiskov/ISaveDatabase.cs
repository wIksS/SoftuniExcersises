using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseLiskov
{
    internal interface ISaveDatabase
    {
        void Save(Scoreboard score);
    }
}
