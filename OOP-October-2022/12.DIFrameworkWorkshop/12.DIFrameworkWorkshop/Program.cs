using _12.DIFrameworkWorkshop.DI;
using _12.DIFrameworkWorkshop.Drawers;
using _12.DIFrameworkWorkshop.Drawers.Contracts;
using DIFramework.Contracts;

namespace _12.DIFrameworkWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceProvider diProvider = DependencyInjectionService.ConfigureServices();

            Engine engine = (Engine)diProvider.GetService(typeof(Engine));


            engine.Run();
        }
    }
}
