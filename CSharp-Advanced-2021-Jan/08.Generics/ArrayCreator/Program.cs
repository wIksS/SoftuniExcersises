using System;
using System.Collections.Generic;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string>[] array = ArrayCreator.Create(5, new List<string>() { "pesho", "muci" });

            foreach (var item in array)
            {
                foreach (var name in item)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
