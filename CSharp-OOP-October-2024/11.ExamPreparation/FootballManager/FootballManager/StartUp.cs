using FootballManager.Core;
using FootballManager.Core.Contracts;

namespace FootballManager
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
