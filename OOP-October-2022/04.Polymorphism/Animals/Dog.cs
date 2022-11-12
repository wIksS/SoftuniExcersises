using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public string ExplainSelf()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ExplainSelf());
            builder.AppendLine("DJAAF");
            return builder.ToString().Trim();
        }
    }
}
