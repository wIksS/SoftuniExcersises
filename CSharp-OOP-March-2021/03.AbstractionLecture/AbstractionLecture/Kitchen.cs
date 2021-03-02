using AbstractionLecture.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLecture
{
    public class Kitchen : IOrderable, IMachinery, ICostCalculatable
    {
        public Kitchen()
        {
            Machineries = new List<string>() { "oven", "pechka", "kotka da qde otpadacite" };
        }
        public List<string> Machineries { get; set; }

        public void OrderMeal(string mealName)
        {
            Console.WriteLine($"Meal ordered {mealName}");
        }

        public void AddProduct(string productName)
        {
            Console.WriteLine($"Product added {productName}");
        }

        public void CalculateCost()
        {
            Console.WriteLine("Current cost is: Too much");
        }

        public void ListAllMachineries()
        {
            foreach (var item in Machineries)
            {
                Console.WriteLine($"Machine: {item}");
            }
        }
    }
}
