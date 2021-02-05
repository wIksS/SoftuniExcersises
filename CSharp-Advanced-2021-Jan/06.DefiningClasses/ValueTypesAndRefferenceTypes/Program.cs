using System;

namespace ValueTypesAndRefferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 5 };
            Bear bear = new Bear();
            bear.Age = 28;
            AgeBear(bear);

            Console.WriteLine(bear.Age);
            Plus(x);
            Console.WriteLine("After method");
            Console.WriteLine(x[0]);
        }
        
        static void AgeBear(Bear bear)
        {
            bear.Age += 55;
        }

        static void Plus(int[] x)
        {
            x[0] += 5;
            Console.WriteLine("In method");
            Console.WriteLine(x[0]);
        }
    }
}
