
namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002,
                "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book east = new Book("Na iztok ot raq", 2002, "Djon", "Stainbek");
            Book nineteen = new Book("1984", 1945, "George");

           // Console.WriteLine(east);

            Library library = new Library(bookOne, bookTwo, bookThree, east, nineteen);

            foreach (Book book in library)
            {
                Console.WriteLine($"{book.Title}, {book.Year} - {String.Join(",",book.Authors)}");
            }
        }
    }
}