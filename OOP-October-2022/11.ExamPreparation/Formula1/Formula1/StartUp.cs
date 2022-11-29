namespace Formula1
{
    using Formula1.Core;
    using Formula1.Core.Contracts;
    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
