using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptions.Exceptions
{
    public class DatabaseException : Exception
    {
        public DatabaseException(string library,Exception inner):base("Cannot connect to database", inner)
        {
            Library = library;
        }

        public string Library { get; set; }
    }
}
