using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("../../../Gogicha");
            //Directory.Move("../../../Gogicha","../../Gogicha");

            string[] files = Directory.GetFiles("../../../");

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
        }
    }
}
