using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopPromotions.Tests.Fakes
{
    internal class FakeDatabase : IDatabase<Product>
    {
        public int numberOfSaveCalls = 0;

        public List<Product> GetAll()
        {
            return new List<Product>();
        }

        public void Save(List<Product> entities)
        {
            numberOfSaveCalls++;
        }
    }
}
