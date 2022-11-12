using System;

namespace ExceptionLifecycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Main");
            try
            {
                First();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Catch!");
            }

            Console.WriteLine("After main");
        }

        private static void First()
        {
            Console.WriteLine("In First");
            try
            {
                Second();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("In Second catch");
                throw;
            }

            Console.WriteLine("After First");
        }

        private static void Second()
        {
            Console.WriteLine("In Second");

            try
            {
                Third();
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine("In Second catch");
                throw;
            }

            Console.WriteLine("After Second");
        }

        private static void Third()
        {
            Console.WriteLine("In Third");

            throw new NotImplementedException();


            Console.WriteLine("After Third");
        }
    }
}
