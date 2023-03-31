using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniIoC.Contracts
{
    public interface IServiceCollection
    {
        IServiceCollection AddTransient<TInterface, TImplementation>();
        IServiceCollection AddTransient<TInterface, TImplementation>(Func<IServiceProvider, object> instantiationFunc);

        Type GetMapping(Type interfaceType);
        Func<IServiceProvider,object> GetInstantiationFunc(Type interfaceType);

        IServiceProvider BuildServiceProvider();
    }
}
