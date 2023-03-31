using _12.DependencyInjectionWorkshop.Contracts;
using ChessDependencyInversion.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop
{
    public class DateProvider : IDateProvider
    {
        public DateProvider(IRenderer renderer, DateTime date)
        {
            Console.WriteLine($"Date is: {date}");
            renderer.WriteLine("DateProvider uses renderer");
            renderer.WriteLine("How am I here?");
        }
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
