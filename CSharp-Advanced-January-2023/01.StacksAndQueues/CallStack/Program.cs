using System;

namespace CallStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            SayHello();

            Console.WriteLine("Ok");
        }

        private static void SayHello()
        {
            SayHowAreYou();

            Console.WriteLine("In Hello");

            SayHowAreYou();
        }

        private static void SayHowAreYou()
        {
            SayYouAreGood();
        }

        private static void SayYouAreGood()
        {
            Console.WriteLine("I am good");
        }
    }
}
