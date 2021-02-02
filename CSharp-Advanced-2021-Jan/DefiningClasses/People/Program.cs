using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person();
            pesho.Name = "Pesho";

            Console.WriteLine(pesho.FullName);
        }
    }
}
