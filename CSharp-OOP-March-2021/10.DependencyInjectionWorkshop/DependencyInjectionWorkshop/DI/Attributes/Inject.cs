using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.DI.Attributes
{
    [AttributeUsage(AttributeTargets.Constructor)]
    class Inject : Attribute
    {
    }
}
