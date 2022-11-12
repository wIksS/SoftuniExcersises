using System;
using System.Collections.Generic;
using System.Text;

namespace MutableConsiderations
{
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public IReadOnlyCollection<Book> Books
        {
            get
            {
                return books.AsReadOnly();
            }
        }

        public int BooksCount
        {
            get
            {
                return books.Count;
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
    }
}
