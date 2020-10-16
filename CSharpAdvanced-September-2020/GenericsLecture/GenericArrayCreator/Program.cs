using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StartUp[] array = ArrayCreator.Create(55, new StartUp());
            Console.WriteLine(string.Join<StartUp>(",", array));
            
        }
    }
}
