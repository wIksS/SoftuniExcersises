using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryWorker person = new FactoryWorker();
            FactoryWorker person2 = new FactoryWorker("BMW");

            //Worker worker = new Worker();
            //FactoryWorker factoryWorker = new FactoryWorker();

            //factoryWorker.Name = "Pesho";

            //Console.WriteLine(factoryWorker.Name);
            //factoryWorker.Sleep();
            //factoryWorker.Eat();
            //factoryWorker.LeaveFactory();
            //Student student = new Student();
            //student.Eat();
        }
    }
}
