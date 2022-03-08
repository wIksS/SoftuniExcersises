using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class Baby : IFeedable
    {
        public int Doze { get; set; }
        public FoodType FoodType { get; set; }

        public void Eat()
        {
            Console.WriteLine("Mryn");
        }
    }
}
