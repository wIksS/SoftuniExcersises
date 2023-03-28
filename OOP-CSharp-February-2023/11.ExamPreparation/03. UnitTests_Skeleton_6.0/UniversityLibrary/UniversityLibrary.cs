namespace UniversityLibrary
{
    using System.Collections.Generic;
    using System.Linq;
    public class UniversityLibrary
    {
        private readonly List<TextBook> textBooks = new List<TextBook>();

        public UniversityLibrary()
        {
            this.textBooks = new List<TextBook>();
        }

        public List<TextBook> Catalogue => this.textBooks;

        public string AddTextBookToLibrary(TextBook textBook)
        {
            textBook.InventoryNumber = textBooks.Count + 1;
            this.textBooks.Add(textBook);
            return textBook.ToString();
        }

        public string LoanTextBook(int bookInventoryNumber, string studentName)
        {
            TextBook textBook = this.textBooks.FirstOrDefault(t => t.InventoryNumber == bookInventoryNumber);

            if (textBook.Holder == studentName)
            {
                return $"{studentName} still hasn't returned {textBook.Title}!";
            }
            else
            {
                textBook.Holder = studentName;

                return $"{textBook.Title} loaned to {studentName}.";
            }

        }

        public string ReturnTextBook(int bookInventoryNumber)
        {
            TextBook textBook = this.textBooks.FirstOrDefault(t => t.InventoryNumber == bookInventoryNumber);

            textBook.Holder = string.Empty;

            return $"{textBook.Title} is returned to the library.";
        }
    }
}
