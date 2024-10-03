

namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main()
        {
            string[] strings = ArrayCreator.Create<string>(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);


            Console.WriteLine(String.Join(" ", strings));
            Console.WriteLine(String.Join(" ", integers));
        }
    }
}