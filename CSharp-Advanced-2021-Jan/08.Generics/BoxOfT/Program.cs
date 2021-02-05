using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            BoxOfT<int> box = new BoxOfT<int>();

            box.Add(1);
            box.Add(2);
            box.Add(3);

            Console.WriteLine(box.Count);

            Console.WriteLine($"Removed: {box.Remove()}");
            Console.WriteLine($"Removed: {box.Remove()}");

            Console.WriteLine(box.Count);
        }
    }
}
