using System;

namespace WhileCycles
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter your age");
            int age;
            do
            {
                //Console.WriteLine("Are you lying???????");
                Console.WriteLine("Enter your age");
                age = int.Parse(Console.ReadLine());
            } while (age < 0 || age > 150);
        }
    }
}
