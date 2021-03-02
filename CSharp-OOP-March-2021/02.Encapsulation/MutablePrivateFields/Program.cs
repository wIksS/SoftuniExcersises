using System;

namespace MutablePrivateFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Human goshko = new Human();
            Book book = goshko.Book;
            goshko.Book.Name = "5";
        }
    }
}
