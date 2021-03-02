using AbstractionLecture.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLecture
{
    class GourmetKitchen : IOrderable, ICostCalculatable, IMachinery
    {
        public GourmetKitchen()
        {
            Machineries = new List<string>() { "oven", "pechka", "nqma otpadaci nqma i kotka" };
        }
        public List<string> Machineries { get; set; }

        public void OrderMeal(string mealName)
        {
            Console.WriteLine($"Meal ordered {mealName} ama shte porychash oshte");
        }

        public void AddProduct(string productName)
        {
            Console.WriteLine($"Product added {productName} ama ne se vijda");
        }

        public void CalculateCost()
        {
            Console.WriteLine("Current cost is: waaaaaaaay Too much");
        }

        public void ListAllMachineries()
        {
            foreach (var item in Machineries)
            {
                Console.WriteLine($"Machine: {item} ama se 4upqt");
            }
        }
    }
}
