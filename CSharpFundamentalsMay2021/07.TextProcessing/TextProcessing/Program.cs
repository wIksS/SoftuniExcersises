using System;
using System.Collections.Generic;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Dimitrichko";
            //name = "Pesho";          
            // (invalid) name[0] = 'P';
            name += "   ";
            name += "top";

            name = name.Insert(0, "pesho");
            Console.WriteLine(name);

            char[] scary = new char[] { 'S', 'C', 'A', 'R', 'Y' };
            string movie =  new string(scary);

            Console.WriteLine(movie);

            Console.WriteLine(movie.ToCharArray());

            Console.WriteLine(string.Concat("Left part", "Right part", "Last part"));

        }
    }
}
