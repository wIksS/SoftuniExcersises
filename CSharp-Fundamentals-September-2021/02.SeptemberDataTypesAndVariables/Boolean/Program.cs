using System;

namespace Boolean
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine((int)1.5);
            //357
            //35
            //3
            //0
            //15
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                bool isSpecial = false;

                if (sum == 7 || sum == 5 || sum == 11)
                {
                    //Console.WriteLine(i);
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            }
           
        }
    }
}
