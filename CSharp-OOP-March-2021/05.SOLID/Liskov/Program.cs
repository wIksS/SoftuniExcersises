using System;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();

            Console.WriteLine(fruit.GetColor());

            //IWorker worker = new Person();

            //worker.Eat();
            //worker.Sleep();

            //IWorker robot = new Robot();

            //robot.Work();
            //robot.Sleep();
        }
    }
}
