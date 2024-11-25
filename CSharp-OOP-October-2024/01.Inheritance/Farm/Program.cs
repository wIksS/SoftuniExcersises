

namespace Farm
{
    public class StartUp
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Puppy puppy = new Puppy();

            Cat cat = new Cat();
            cat.Eat();
        }
    }
}