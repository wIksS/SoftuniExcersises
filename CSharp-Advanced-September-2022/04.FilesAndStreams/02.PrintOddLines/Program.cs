using System;
using System.IO;

namespace _02.PrintOddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../scoreboard.txt"))
            {
                using (StreamWriter writer= new StreamWriter("../../../oddlines.txt"))
                {
                    int row = 0;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine(); 
                        if (row++ % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                    }
                }
            }
        }
    }
}
