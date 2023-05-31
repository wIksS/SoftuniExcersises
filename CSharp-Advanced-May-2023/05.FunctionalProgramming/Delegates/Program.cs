
namespace Delegates
{
    class Program
    {
        delegate int TwoNumbersOperation(decimal a, float b);

        public static void Main(string[] args)
        {
            Func<decimal, float, int> func = Sum;
            TwoNumbersOperation delegateFunc = Sum;

            Console.WriteLine(func(5, 6));
            Console.WriteLine(delegateFunc(5, 6));

        }

        static int Sum(decimal a, float b)
        {
            return (int)((float)a + b);
        }
    }
}