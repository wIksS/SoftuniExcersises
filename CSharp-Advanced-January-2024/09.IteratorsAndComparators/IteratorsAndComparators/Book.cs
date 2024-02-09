using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors.ToList();
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public int CompareTo(Book? other)
        {
            int yearsComparison = Year.CompareTo(other.Year);
            if (yearsComparison == 0)
            {
                return Title.CompareTo(other.Title);
            }

            return yearsComparison;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
