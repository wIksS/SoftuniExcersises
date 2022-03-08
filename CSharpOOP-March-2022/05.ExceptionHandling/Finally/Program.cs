using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Na kolko si?");
            int y = 0;
            try
            {
                int n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                int x = 0 / y;

                Console.WriteLine("Ne uspq");
                int n = int.Parse(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Blagodarq za vnimanieto");
            }

            Console.WriteLine("Blagodarq za vnimanieto izvyn finally");

        }
    }
}
