using System;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'a'; // An ordinary character
            Console.WriteLine(symbol);
            symbol = '\u006F'; // Unicode character code in a
            Console.WriteLine(symbol);
            // hexadecimal format (letter 'o')
            symbol = '\u8449'; // 葉 (Leaf in Traditional Chinese)
            Console.WriteLine(symbol);
            symbol = '\''; // Assigning the single quote character
            Console.WriteLine(symbol);
            symbol = '\\'; // Assigning the backslash character
            Console.WriteLine(symbol);
            symbol = '\n'; // Assigning new line character
            Console.WriteLine(symbol);
            symbol = '\t'; // Assigning TAB character
            Console.WriteLine(symbol);

            //symbol = "a";  // Incorrect: use single quotes!
        }
    }
}
