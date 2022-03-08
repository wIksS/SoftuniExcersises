using System;

namespace ExceptionStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MethodA();
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught in A");
            }
        }

        private static void MethodA()
        {
            MethodB();
            throw new ArgumentException();

        }

        private static void MethodB()
        {
            try
            {
                MethodC();

            }
            catch (Exception)
            {

                Console.WriteLine("Caught in B");
            }
        }

        private static void MethodC()
        {
            throw new ArgumentException();
        }
    }
}
