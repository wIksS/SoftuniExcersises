using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI
{
    public class ServiceCollection
    {
        private Dictionary<Type, Type> mappings;
        private Dictionary<Type, Func<IServiceProvider, object>> mappingsWithFactories;

        public ServiceCollection()
        {
            mappings = new Dictionary<Type, Type>();
            mappingsWithFactories = new Dictionary<Type, Func<IServiceProvider, object>>();
        }

        // ILogger -> ConsoleLogger
        public void AddSingleton(Type interfaceType, Type implementationType)
        {
            mappings.Add(interfaceType, implementationType);
        }

        public void AddSingleton<TInterface, TImplementation>()
        {
            AddSingleton(typeof(TInterface), typeof(TImplementation));  
        }

        public void AddSingleton<TInterface, TImplementation>(Func<IServiceProvider, object> factory)
        {
            AddSingleton(typeof(TInterface), factory);
        }

        public void AddSingleton(Type interfaceType, Func<IServiceProvider, object> factory)
        {
            mappingsWithFactories.Add(interfaceType, factory);
        }

        public Type GetMapping(Type interfaceType)
        {
            return mappings[interfaceType];
        }

        public Func<IServiceProvider, object> GetFactoryMapping(Type interfaceType)
        {
            if (!mappingsWithFactories.ContainsKey(interfaceType))
            {
                return null;
            }

            return mappingsWithFactories[interfaceType];
        }

        public IServiceProvider BuildServiceProvider()
        {
            return new ServiceProvider(this);
        }
    }
}
