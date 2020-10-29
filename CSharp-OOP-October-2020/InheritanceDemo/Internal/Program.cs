using System;

namespace Internal
{
    class Program
    {
        static void Main(string[] args)
        {
            ShavingFoam foam = new ShavingFoam();
            foam.Id = 5;
            foam.CanBuy(10);
            foam.Name = "Nivea";
        }
    }
}
