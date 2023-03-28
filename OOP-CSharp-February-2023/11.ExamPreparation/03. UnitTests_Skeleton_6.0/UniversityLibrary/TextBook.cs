namespace UniversityLibrary
{
    using System.Text;
    public class TextBook
    {
        public TextBook(string title, string author, string category)
        {
            Title = title;
            Author = author;
            Category = category;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public int InventoryNumber { get; set; }

        public string Category { get; set; }

        public string Holder { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Book: {Title} - {InventoryNumber}");
            sb.AppendLine($"Category: {Category}");
            sb.AppendLine($"Author: {Author}");

            return sb.ToString().TrimEnd();
        }
    }
}
