namespace Funcs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, string> func = Sum;
            Func<float, decimal, string> func2 = Sum;

            func(5,5);

            func2(6,5);
        }

        static string Sum(int a, int b)
        {
            Console.WriteLine("Int");
            return "";
        }

        static string Sum(float a, decimal b)
        {
            Console.WriteLine("Float");
            return "";
        }
    }
}