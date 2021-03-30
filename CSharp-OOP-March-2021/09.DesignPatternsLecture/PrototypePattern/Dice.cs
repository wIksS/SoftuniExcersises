using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class Dice : ICloneable
    {
        public int Side { get; set; }

        public string Color { get; set; }

        public Player Player { get; set; }

        public object Clone()
        {
            // shallow copy
            Dice newDice = this.MemberwiseClone() as Dice;
            newDice.Player = Player.Clone() as Player;
            return newDice;
        }
    }
}
