using System;

namespace MethodsFundamentals
{
    class Program
    {
        static void PrintTriangle()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(new string('*', i *2));
            }
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(new string('*', i*2));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(new string('-',20));
            PrintTriangle();
            PrintTriangle();
            PrintTriangle();












            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(new string('*',i*2));
            //}
            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(new string('*', i));
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(new string('*', i));
            //}
            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(new string('*', i));
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(new string('*', i));
            //}
            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine(new string('*', i));
            //}

        }


    }
}
