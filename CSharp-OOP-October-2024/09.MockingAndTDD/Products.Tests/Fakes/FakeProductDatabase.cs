using Products.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Tests.Fakes
{
    internal class FakeProductDatabase : IProductDatabase
    {
        public List<string> LoadProducts()
        {
            return new List<string>();  
        }

        public void Save(List<string> products)
        {
            SaveTimesCalled++;
        }

        public int SaveTimesCalled { get; set; }
    }
}
