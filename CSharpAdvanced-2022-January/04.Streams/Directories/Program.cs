using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("../../../CoolDir");
           // Directory.Move("../../../bin/CoolDir2", "../../../bin/CoolDir3");
            Directory.Delete("../../../bin/CoolDir3",true);

        }
    }
}
