using _12.DependencyInjectionWorkshop.Contracts;
using ChessDependencyInversion.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop
{
    public class Scoreboard
    {
        private IDateProvider dateProvider;
        private readonly ILogger logger;
        private readonly IRenderer renderer;
        public Scoreboard(IRenderer renderer, IDateProvider dateProvider, ILogger logger)
        {
            this.renderer = renderer;
            this.dateProvider = dateProvider;
            this.logger = logger;
        }

        public void DrawScore()
        {
            logger.Log("Drawing score");
            renderer.WriteLine($"{dateProvider.GetDate()} Score is: 5");
        }
    }
}
