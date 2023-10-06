

namespace BoxOfT
{
    public class StartUp
    {
        static void Main()
        {
            Box<int> box = new Box<int>();

            box.Add(1);
            box.Add(2);
            box.Add(3);
            box.Add(4);

            Console.WriteLine(box.Remove()) ;
        }
    }
}