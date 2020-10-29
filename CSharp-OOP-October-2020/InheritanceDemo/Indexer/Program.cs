using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(book["0"]);
        }

        class Book
        {
            private string[] pages = new string[]
            {
                "page 1 content",
                "page 2 content",
                "page 3 content",
                "page 14 content",

            };

            public string this[string i]
            {
                get { return pages[int.Parse(i)]; }
            }
        }
    }
}
