using System;
using System.Collections.Generic;
using System.Text;

namespace DIFramework.Contracts
{
    public interface IServiceProvider
    {
        object GetService(Type serviceType);
    }
}
