using DependencyInjectionWorkshop.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Contracts
{
    interface IGameObject : IDrawable
    {
        Position Position { get; }
    }
}
