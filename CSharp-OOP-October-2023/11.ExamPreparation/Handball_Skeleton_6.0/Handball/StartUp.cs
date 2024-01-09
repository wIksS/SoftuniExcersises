using Handball.Core;
using Handball.Core.Contracts;
using System.Collections.Generic;

namespace Handball
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
