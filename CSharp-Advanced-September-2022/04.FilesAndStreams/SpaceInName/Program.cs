using System;
using System.IO;

namespace SpaceInName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../pap ka/sco reboard.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
