using System;
using System.Collections.Generic;
using System.Text;

namespace RestarauntNoEncapsulation
{
    public class Ingredient
    {
        public Ingredient(string name, int weight)
        {
            Name = name;
            WeightInGrams = weight;
        }
        public string Name { get; set; }

        public int WeightInGrams { get; set; }
    }
}
