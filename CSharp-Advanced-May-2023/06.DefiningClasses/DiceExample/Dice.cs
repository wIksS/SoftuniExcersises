using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceExample
{
    public class Dice
    {
        public int side;
        public string color;

        public void Roll()
        {
            //Console.WriteLine(this);
            Console.WriteLine($"Dice {side} was rolled");
            this.side = 5;
        }
    }
}
