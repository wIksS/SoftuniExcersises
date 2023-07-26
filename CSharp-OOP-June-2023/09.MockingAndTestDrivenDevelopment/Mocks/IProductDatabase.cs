using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocks
{
    public interface IProductDatabase
    {
        public void Add(string product);

        public bool Delete(string product);

        public IEnumerable<string> GetAll();

        public void Save();
    }
}
