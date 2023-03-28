using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Dice : ICloneable
    {
        public int Sides { get; set; }

        public int Thrown { get; set; }

        public User Thrower { get; set; }


        //Shallow clone
        //public object Clone()
        //{
        //    Dice dice = new Dice();

        //    dice.Sides = Sides;
        //    dice.Thrown = Thrown;
        //    dice.Thrower = Thrower;

        //    return dice;
        //}

        //Deep clone
        public object Clone()
        {

            string dice = JsonConvert.SerializeObject(this,Formatting.Indented);
            Console.WriteLine(dice);
            Dice newDice = JsonConvert.DeserializeObject<Dice>(dice);

            return newDice;
        }

    }
}
