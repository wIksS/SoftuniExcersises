using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList<string> list2 = new RandomList<string>();
            Console.WriteLine(list2.RandomString());
            RandomList<string> list = new RandomList<string>();
            list.Add("Pesho");
            list.Add("Gogi");
            list.Add("Gigi");
            list.Add("Mishi");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list.RandomString());
            }
        }
    }
}
