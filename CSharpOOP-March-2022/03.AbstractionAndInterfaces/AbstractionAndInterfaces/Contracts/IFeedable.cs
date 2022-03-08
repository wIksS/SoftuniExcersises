using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.Contracts
{
    public interface IFeedable
    {
        void Eat();

        int Doze { get; set; }

        FoodType FoodType { get; set; }
    }
}
