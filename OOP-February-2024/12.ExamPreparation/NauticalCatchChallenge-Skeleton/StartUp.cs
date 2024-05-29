namespace NauticalCatchChallenge
{
    using NauticalCatchChallenge.Core;
    using NauticalCatchChallenge.Core.Contracts;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}