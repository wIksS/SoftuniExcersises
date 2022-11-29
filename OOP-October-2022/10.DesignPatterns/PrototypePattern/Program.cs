using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice(1)
            {
                Side = new Side()
                {
                    Number = 5,
                    Times = 0
                }
            };

            Dice dice2 = (Dice)dice.Clone();

            dice2.Id = 2;
            dice2.Side.Number = 55;

            Console.WriteLine(dice.Id);
            Console.WriteLine(dice2.Id);

            Console.WriteLine("Sides:");

            Console.WriteLine(dice.Side.Number);
            Console.WriteLine(dice2.Side.Number);
        }
    }
}
