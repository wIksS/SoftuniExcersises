using System;
using System.IO;

namespace Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Directory.CreateDirectory($"../../../{i+1}.CustomFolder");
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Directory.Delete($"../../../{i + 1}.CustomFolder");
            //}

            for (int i = 0; i < 10; i++)
            {
                Directory.Move($"../../../CustomFolder/{i + 1}.MovedCustomFolder", $"../../../CustomFolder/{i + 1}.CustomFolder");
            }
        }
    }
}
