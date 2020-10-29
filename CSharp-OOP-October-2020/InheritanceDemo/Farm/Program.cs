using Internal;
using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ShavingFoam foam = new ShavingFoam();
            foam.Name = "Nivea 2";
            Dog sharo = new Dog();
            sharo.Eat();
            sharo.Bark();

            Puppy goshko = new Puppy();
            goshko.Weep();
        }
    }
}
