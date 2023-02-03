using GenericsNS;
List<int> list = new List<int>()
{
    1,2,3,4,5
};

List<long> longList = new List<long>()
{
    1,2,3,4,5,6
};

List<string> stringList = new List<string>()
{
    "edno","dve","chetiri"
};

Generics.PrintList(list);
Generics.PrintList(longList);
Generics.PrintList(stringList);

namespace GenericsNS
{
    public class Generics
    {
        public static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void PrintList(List<long> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }

}
