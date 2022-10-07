using System;
using System.Collections.Generic;

namespace DiceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dice> dices = new List<Dice>();
            while (true)
            {
                Console.ReadLine();
                Dice dice = ThrowDice();
                dices.Add(dice);
                PrintDice(dice);
            }

        }

        static Dice ThrowDice()
        {
            Random random = new Random();

            int side = random.Next(1, 7);

            Dice dice = new Dice()
            {
                Side = side,
                Color = "Pink"
            };

            return dice;
        }

        static void PrintDice(Dice dice)
        {
            Console.WriteLine($"Dice: {dice.Side}");
            dice.Side++;
            dice.Color = "Red";
        }
    }
}
