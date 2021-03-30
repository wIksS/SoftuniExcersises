using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.DI.Containers
{
    public interface IContainer
    {
        void ConfigureServices();

        void CreateMapping<TInterfaceType, TImplementationType>();

        void CreateMapping<TInterfaceType, TImplementationType>(Func<object> creationFunc);

        Type GetMapping(Type interfaceType);

        KeyValuePair<Type, Func<object>> GetCustomMapping(Type interfaceType);
    }
}
