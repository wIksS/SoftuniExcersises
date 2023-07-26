using _12.DependencyInjectionWorkshop.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniIoC.Example
{
    internal class Engine
    {
        private IRenderer renderer;

        public Engine(IRenderer renderer, int frameRate)
        {
            this.renderer = renderer;

            renderer.WriteLine($"Game running in : {frameRate}");
        }
    }
}
