using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReadOnlyCollection
            IAnimal baseAnimal = new Ant();// new Programmer("Dimitrichko");

            if (baseAnimal is Programmer peshoProgramista)
            {
                peshoProgramista.Work();
            }

            if (baseAnimal is IPerson)
            {
                IPerson person = (IPerson)baseAnimal;
            }
            if (baseAnimal is Programmer)
            {
                Programmer programmer = (Programmer)baseAnimal;
            }

            if (baseAnimal is IAnimal)
            {
                Console.WriteLine("baseAnimal is IbaseAnimal");
            }
            if (baseAnimal is IPerson)
            {
                Console.WriteLine("Is IPerson");
            }
            if (baseAnimal is Program)
            {
                Console.WriteLine("Is baseAnimal");
            }
            if (baseAnimal is Object)
            {
                Console.WriteLine("Is Object");
            }

            if (!(baseAnimal is Ant))
            {
                Console.WriteLine("Is Not Ant");
            }


            //baseAnimal.Eat();
            //person.Work();
            //baseAnimal.Work();
            //baseAnimal.Eat();
        }

        class Ant : IAnimal
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }
        }
    }
}
