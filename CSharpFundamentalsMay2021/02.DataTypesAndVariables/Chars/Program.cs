using System;

namespace Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            char symbol = '\u2605';
            Console.WriteLine(symbol);
            char ch = 'a';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'b';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'A';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'щ';  // Cyrillic letter 'sht'
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);

        }
    }
}
