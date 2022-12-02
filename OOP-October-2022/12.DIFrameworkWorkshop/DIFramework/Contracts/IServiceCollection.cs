using System;
using System.Collections.Generic;
using System.Text;

namespace DIFramework.Contracts
{
    public interface IServiceCollection
    {
        void AddTransient<TInterface, TImplementation>();
        void AddTransient<TInterface, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory);

        Type GetMapping(Type interfaceType);
        Func<IServiceProvider, TImplementation> GetFactory<TImplementation>(Type implementationType);

        IServiceProvider BuildServiceProvider();
    }
}
