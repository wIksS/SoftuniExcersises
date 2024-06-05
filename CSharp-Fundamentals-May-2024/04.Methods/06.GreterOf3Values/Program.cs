namespace GreaterOfThree
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int bigger = GetBigger(a, b);
                Console.WriteLine(bigger);
            }

            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                char bigger = GetBigger(a, b);
                Console.WriteLine(bigger);
            }

            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string bigger = GetBigger(a, b);
                Console.WriteLine(bigger);
            }
        }

        static int GetBigger(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static char GetBigger(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetBigger(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}