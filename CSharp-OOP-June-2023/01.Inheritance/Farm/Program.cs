namespace Farm
{
    public class StartUp
    {
        static void Main()
        {
            Animal animal = new Animal();

            animal.Eat();

            Puppy dog = new Puppy();

            dog.Eat();

            dog.Bark();

            dog.Weep();
        }
    }

}