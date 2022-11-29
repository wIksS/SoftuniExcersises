using System;
using System.Collections.Generic;
using System.Text;

namespace Promotions.Contracts
{
    public interface IProductDatabase
    {
        public void Save(List<Product> products);

        public List<Product> GetAll();
    }
}
