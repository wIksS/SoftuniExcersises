using System;
using System.Collections.Generic;
using System.Text;

namespace MutablePrivateFields
{
    class Human
    {
        private Book book;

        public Human()
        {
            this.book = new Book() { Name = "Pipi", CurrentPage = 42 };
        }
        public Book Book
        {
            get
            {
                return this.book;
            }
        }
    }
}
