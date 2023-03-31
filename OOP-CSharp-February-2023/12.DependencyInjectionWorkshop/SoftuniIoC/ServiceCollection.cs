using SoftuniIoC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IServiceProvider = SoftuniIoC.Contracts.IServiceProvider;

namespace SoftuniIoC
{
    public class ServiceCollection : IServiceCollection
    {
        private Dictionary<Type, Type> mappings;
        private Dictionary<Type, Func<IServiceProvider, object>> mappingFuncs;

        public ServiceCollection()
        {
            mappings = new Dictionary<Type, Type>();
            mappingFuncs = new Dictionary<Type, Func<IServiceProvider, object>>();
        }

        public IServiceCollection AddTransient<TInterface, TImplementation>()
        {
            mappings.Add(typeof(TInterface), typeof(TImplementation));

            return this;
        }

        public IServiceCollection AddTransient<TInterface, TImplementation>(Func<Contracts.IServiceProvider, object> instantiationFunc)
        {
            AddTransient<TInterface,TImplementation>();

            mappingFuncs.Add(typeof(TInterface), instantiationFunc);

            return this;
        }

        public Type GetMapping(Type interfaceType)
        {
            return mappings[interfaceType];
        }

        public Func<IServiceProvider, object> GetInstantiationFunc(Type interfaceType)
        {
            if (mappingFuncs.ContainsKey(interfaceType))
            {
                return mappingFuncs[interfaceType];
            }

            return null;
        }

        public Contracts.IServiceProvider BuildServiceProvider()
        {
            return new ServiceProvider(this);
        }


    }
}
