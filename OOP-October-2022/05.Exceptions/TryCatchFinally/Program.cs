using System;

namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());

            }
   
            catch (Exception ex)
            {
                Console.WriteLine("Caught ex");
                throw new ArgumentException();
                Console.WriteLine("AFter argument");
            }
            finally
            {
                Console.WriteLine("This code always executes");
                Console.WriteLine("You typed it beautifully");
            }

            Console.WriteLine("After try finally");

         

        }
    }
}
