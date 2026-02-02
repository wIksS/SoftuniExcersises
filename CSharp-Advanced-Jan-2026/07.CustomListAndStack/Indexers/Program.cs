namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list["Georgi", 2] = "5";
            Console.WriteLine(list["55", 1]);

        }

    }

    class CustomList
    {

        public string this[string key, int index]
        {
            get
            {
                Console.WriteLine($"Getting value at {index}");
                return "-1";
            }
            set
            {
                Console.WriteLine($"Setting {value}");
            }
        }
    }
}
