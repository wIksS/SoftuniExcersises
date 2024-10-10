using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            //for (int i = 0; i < Books.Count; i++)
            //{
            //    yield return Books[i];
            //}

            Books.Sort(new BookComparator());
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index = -1;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => books[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return books.Count > ++index;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
