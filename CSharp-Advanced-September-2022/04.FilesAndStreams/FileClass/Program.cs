using System;
using System.IO;

namespace FileClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../text.txt";
            //string text = File.ReadAllText("../../../text.txt");
            //string[] lines = File.ReadAllLines("../../../text.txt");
            //File.Move("../../text.txt", "../../../text.txt");
            Console.WriteLine(File.GetCreationTime(path));
            //Console.WriteLine(File.(path));
            //Console.WriteLine(lines.Length);

            //Console.WriteLine(text);
        }
    }
}
