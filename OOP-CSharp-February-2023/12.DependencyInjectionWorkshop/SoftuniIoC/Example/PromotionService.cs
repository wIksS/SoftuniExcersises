using _12.DependencyInjectionWorkshop.Contracts;
using ChessDependencyInversion.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniIoC.Example
{
    internal class PromotionService : IPromotionService
    {
        private readonly IDateProvider dateProvider;
        private readonly IRenderer renderer;

        public PromotionService(IDateProvider dateProvider, IRenderer renderer)
        {
            this.dateProvider = dateProvider;
            this.renderer = renderer;
        }


        public void GetPromotion()
        {
            renderer.WriteLine($"{dateProvider.GetDate().DayOfWeek} is the Best Day for Promotion!");
        }
    }
}
