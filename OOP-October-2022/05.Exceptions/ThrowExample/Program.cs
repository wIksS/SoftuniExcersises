using System;

namespace ThrowExample
{
    internal class Program
    {
        public static double Sqrt(double value)
        {
            if (value < 0)
                throw new System.ArgumentOutOfRangeException("value",
                  "Sqrt for negative numbers is undefined!");
            return Math.Sqrt(value);
        }
        static void Main()
        {
            try
            {
                Sqrt(-1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
                throw;
            }
        }

    }
}
