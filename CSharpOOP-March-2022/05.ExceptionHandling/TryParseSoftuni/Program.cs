using System;

namespace TryParseSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=8;
            TryParse("5", out result);
            Console.WriteLine(result);
        }

        public static void TryParse(string input, out int x)
        {
            try
            {
                x = int.Parse(input);
            }
            catch (FormatException ex)
            {
                x = 0;
            }
        }
    }
}
