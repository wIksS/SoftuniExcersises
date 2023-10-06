

namespace GenericScale
{
    public class StartUp
    {
        static void Main()
        {
            EqualityScale<int> scale = new EqualityScale<int>(5,6);

            Console.WriteLine(scale.AreEqual());

            Console.WriteLine(scale.GetBigger());
        }
    }
}