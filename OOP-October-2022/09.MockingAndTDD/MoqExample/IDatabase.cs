using Promotions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoqExample
{
    public interface IDatabase
    {
        public void Save();

        public List<Product> GetAll();

        public void Update(Product product);

        public void Delete(int id);

        public int Count { get; }
    }
}
