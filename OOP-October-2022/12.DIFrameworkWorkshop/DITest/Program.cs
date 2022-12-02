
using _12.DIFrameworkWorkshop.Renderers;
using DIFramework.Contracts;
using System;
using System.Reflection;

namespace DITest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DIFramework.Contracts.IServiceProvider provider = ServiceConfigurator.ConfigureServices();

            Engine engine = (Engine)provider.GetService(typeof(Engine));

            Type type = DateTime.Now.GetType();

            MethodInfo method = typeof(Engine).GetMethod("Test");
            method = method.MakeGenericMethod(type);
            method.Invoke(null,null);
        }
    }

    class Engine
    {
        public Engine(IRenderer renderer)
        {
            renderer.WriteLine("In Engine");
        }

        public static void Test<T>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}
