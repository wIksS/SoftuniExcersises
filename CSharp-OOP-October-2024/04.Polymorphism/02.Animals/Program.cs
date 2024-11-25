namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            Animal animal = null;

            if (new Random().Next() % 2 == 0)
            {
                animal = new Cat("Peter", "Whiskas");
            }
            else
            {
                animal = new Dog("George", "Meat");
            }

            Console.WriteLine(animal.ExplainSelf());
        }
    }
}