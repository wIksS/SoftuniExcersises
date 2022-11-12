using System;

namespace DependencyInjectionPromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(new DateTime(2022,11,8));

            store.Buy(new Product());
        }
    }
}
