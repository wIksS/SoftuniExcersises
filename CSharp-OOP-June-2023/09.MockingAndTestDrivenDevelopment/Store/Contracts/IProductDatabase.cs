using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Contracts
{
    public interface IProductDatabase
    {
        public void Add(Product product);

        public bool Delete(Product product);

        public IEnumerable<Product> GetAll();

        public void Save();
    }
}
