using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02._Books_Before
{
    public class Library
    {
        private List<BookLocation> bookLocations;

        public Library()
        {
            bookLocations = new List<BookLocation>();
        }

        public void AddBook(Book book)
        {
            bookLocations.Add(new BookLocation() { Book = book, Location = 0 });
        }

        public int TurnPage(Book book)
        {
            BookLocation bookLocation = bookLocations.First(b => b.Book == book);

            return bookLocation.TurnPage();
        }
    }
}
