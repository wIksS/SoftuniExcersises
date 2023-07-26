using _12.DependencyInjectionWorkshop.Contracts;
using _12.DependencyInjectionWorkshop.Loggers;
using _12.DependencyInjectionWorkshop.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop
{
    internal class Engine
    {
        private IRenderer renderer;
        private IDrawable[] figures;
        public Engine(IRenderer renderer, ILogger logger)
        {
            this.renderer = renderer;
            figures = new IDrawable[5]
            {
                new Pawn(renderer),
                new Pawn(renderer),
                new Pawn(renderer),
                new Pawn(renderer),
                new Pawn(renderer),

            };
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                foreach (var item in figures)
                {
                    item.Draw();
                }
                renderer.WriteLine("Chess game is running");
            }
        }
    }
}
