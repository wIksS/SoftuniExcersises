

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main()
        {
            string[] list = ArrayCreator.Create(300, "Dimitirchko");

            Console.WriteLine(list.ToString());

           // Console.WriteLine(String.Join(", ", list));
        }
    }
}