using Promotions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoqExample
{
    internal class FakeDatabase : IDatabase
    {
        public int Count => throw new NotImplementedException();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

    }
}
