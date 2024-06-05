
namespace Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Add(5,6));

            int result = Add(5, 6,7);

            double result2 = Add(5d, 6d);
        }

        static double Add(double a, double b)
        {
            return a - b;
        }


        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            Console.WriteLine("Calling three number");

            return a + b + c;
        }
    }
}