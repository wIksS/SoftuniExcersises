using DependencyInjectionWorkshop.Common;
using DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Movers
{
    class SlowMover : IMover
    {
        public void Move(IGameObject gameObject, Position position)
        {
            gameObject.Position.X += position.X;
            gameObject.Position.Y += position.Y;
        }
    }
}
