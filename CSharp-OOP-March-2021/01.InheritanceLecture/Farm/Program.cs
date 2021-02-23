using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy sharo = new Puppy();
            sharo.Eat();
            sharo.Bark();
            sharo.Weep();

            Cat sharo2 = new Cat();
            
            sharo2.Meow();
        }
    }
}
