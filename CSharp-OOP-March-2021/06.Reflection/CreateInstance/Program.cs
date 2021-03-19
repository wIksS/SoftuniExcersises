using System;
using System.Text;

namespace CreateInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Type sbType = typeof(StringBuilder);
            //StringBuilder sb = (StringBuilder)Activator.CreateInstance(sbType);

            StringBuilder sb = (StringBuilder)
                Activator.CreateInstance(sbType, new object[] { "HeyHey" });

            sb.Append("Hello");
            Console.WriteLine(sb);
        }
    }
}
