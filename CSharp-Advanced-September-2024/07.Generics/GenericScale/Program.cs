

namespace GenericScale
{
    public class StartUp
    {
        public static void Main()
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(7,3);

            Console.WriteLine(equalityScale.IsLeftBigger());

        }
    }
}