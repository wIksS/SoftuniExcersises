using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Constants
    {
        //const
        public static readonly int NumberOfPlayers = 4;
        public static readonly string GameName = "Best of the best Game";

        static Constants()
        {
            NumberOfPlayers = 55;
        }

        public static int MyProperty { get; set; }
        public static void PrintMessage()
        {
            Console.WriteLine("Global method");
        }
    }
}
