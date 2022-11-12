using System;
using System.Collections.Generic;
using System.Linq;

namespace MutableConsiderations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book());
            library.AddBook(new Book());
            library.AddBook(new Book());
            library.AddBook(new Book());
            library.AddBook(new Book());

            IReadOnlyCollection<Book> booksReadOnly = library.Books;
            List<Book> books = booksReadOnly.ToList();
            //library.Books = new List<Book>();
            books.RemoveAll(b => true);

            Console.WriteLine(library.BooksCount);
            X x = new XX();
           
        }
    }

    class XX : X
    {
         void X.Y()
        {
            throw new NotImplementedException();
        }
    }
    interface X
    {
        public void Y();
    }
}
