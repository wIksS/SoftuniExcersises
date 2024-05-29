
namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            Animal animal = new Dog("Sharo", "Tom");
            Random rand = new Random();
            if (rand.Next() % 2 == 0 )
            {
                animal = new Cat("Tom", "Djeri");
            }

            Console.WriteLine(animal.ExplainSelf());

        }
    }
}