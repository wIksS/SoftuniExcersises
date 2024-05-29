using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopPromotions
{
    public interface IDatabase<T>
    {
        public List<T> GetAll();

        public void Save(List<T> entities);
    }
}
