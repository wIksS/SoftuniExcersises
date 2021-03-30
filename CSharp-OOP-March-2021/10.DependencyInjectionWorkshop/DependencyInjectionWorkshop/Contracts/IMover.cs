using DependencyInjectionWorkshop.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Contracts
{
    interface IMover
    {
        void Move(IGameObject gameObject, Position position);
    }
}
