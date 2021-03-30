using Autofac;
using DependencyInjectionWorkshop.Contracts;
using DependencyInjectionWorkshop.DI;
using DependencyInjectionWorkshop.DI.Containers;
using DependencyInjectionWorkshop.Loggers;
using System;

namespace DependencyInjectionWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = InjectorSingleton.Instance.Resolve<Engine>();

            engine.Start();
            engine.End();
        }
    }
}
