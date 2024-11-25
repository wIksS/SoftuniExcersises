using SoftUniDB.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB
{
    internal class SoftUniDBRepository
    {
        private string connectionString;
        public SoftUniDBRepository(string connectionString)
        {
            if (!File.Exists(connectionString))
            {
                throw new SoftUniDBException("Error initializing", new FileNotFoundException($"{connectionString} is not a valid file path"));
            }

            this.connectionString = connectionString;
        }

        public string Read()
        {
            using (StreamReader reader = new StreamReader(connectionString))
            {
                string db = reader.ReadToEnd();

                if (String.IsNullOrWhiteSpace(db))
                {
                    throw new SoftUniDBException("Error initializing", new ArgumentException("DB not inialized"));
                }

                return db;
            }
        }

        public void Write(string data)
        {
            if (data == null)
            {
                throw new SoftUniDBException("Error writing", new ArgumentNullException("data cannot be null"));
            }
        }

        public void Update(string data)
        {
            if (data == null)
            {
                throw new SoftUniDBException("Error updating", new ArgumentNullException("data cannot be null"));
            }
        }
    }
}
