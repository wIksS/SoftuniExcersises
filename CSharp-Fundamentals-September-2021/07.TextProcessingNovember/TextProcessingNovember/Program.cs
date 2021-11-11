using System;

namespace TextProcessingNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum";
            string lorem = new string(new char[] { 'L', 'o', 'r' });
            char[] loremCharArray = lorem.ToCharArray();
            Console.WriteLine(lorem);
        }
    }
}
