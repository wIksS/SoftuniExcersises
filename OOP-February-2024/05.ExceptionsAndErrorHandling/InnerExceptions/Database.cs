using InnerExceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptions
{
    internal class Database
    {
        public Product[] GetAllProducts()
        {
            try
            {
                DbContext dbContext = new DbContext("");

                dbContext.Database.Create();
            }
            catch(ArgumentException ex)
            {
                throw new DatabaseException("Entity Framework", ex);
            }

            return null;
        }
    }
}
