using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "old old fdsffdsfdsfsd old";

            int indexOf = text.IndexOf("old");

            for (int i = 0; i < 0; i++)
            {
                indexOf = text.IndexOf("old", indexOf + 1);

            }

            Console.WriteLine(indexOf);
        }
    }
}
