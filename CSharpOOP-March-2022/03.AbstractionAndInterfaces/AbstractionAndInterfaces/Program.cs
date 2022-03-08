using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;

namespace AbstractionAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();

            careTaker.Feed(new Eagle());
            careTaker.Feed(new Crocodile());
            careTaker.Feed(new Fish());

            

            careTaker.Feed(new Baby());

            IFeedable feedable = new Lion();
            feedable.Eat();

        }
    }
}
