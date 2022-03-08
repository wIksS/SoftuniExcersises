using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public abstract class Animal : IFeedable
    {
        public Animal(FoodType type, int doze)
        {
            FoodType = type;
            Doze = doze;
        }


        public FoodType FoodType { get; set; }

        public int Doze { get; set; }

        public abstract void Eat();
        public void EatALot()
        {
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping");
        }

        public abstract void Play();
    }
}
