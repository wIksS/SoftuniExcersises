namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] peshos = ArrayCreator.Create(100, "pesho");

            Console.WriteLine(String.Join(" ", peshos));

            int[] ones = ArrayCreator.Create(10000, 1);

            Console.WriteLine(String.Join("", ones));

        }
    }
}