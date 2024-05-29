

namespace Operations
{
    public class StartUp
    {
        public static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine(mathOperations.Add(5, 5));
            Console.WriteLine(mathOperations.Add(5, 5, 5d));
        }
    }
}