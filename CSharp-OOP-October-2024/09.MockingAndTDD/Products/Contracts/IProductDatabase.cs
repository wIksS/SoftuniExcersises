using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Contracts
{
    public interface IProductDatabase
    {
        void Save(List<string> products);

        List<string> LoadProducts();
    }
}
