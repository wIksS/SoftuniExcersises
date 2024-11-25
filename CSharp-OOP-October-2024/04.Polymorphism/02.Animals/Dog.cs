using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public sealed override string ExplainSelf()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ExplainSelf());
            stringBuilder.AppendLine($"DJAAF");

            return stringBuilder.ToString().Trim();
        }
    }

    public class Dakel : Dog
    {
        public Dakel(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public new string ExplainSelf()
        {
            return "";
        }
    }
}
