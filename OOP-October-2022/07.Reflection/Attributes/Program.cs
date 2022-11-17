using System;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    [Serializable]
    class User
    {
        public string Name { get; set; }

        public int  Score { get; set; }
    }

    class Printer
    {
        [Obsolete("No longer needed")]
        public void Print()
        {

        }
    }
}
