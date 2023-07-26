using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniIoC
{
    public class ServiceCollection
    {
        private Dictionary<Type, Type> mappings;
        private Dictionary<Type, Type> singletonMappings;
        private Dictionary<Type, Func<ServiceProvider, object>> factoryMappings;

        public ServiceCollection()
        {
            mappings = new Dictionary<Type, Type>();
            singletonMappings = new Dictionary<Type, Type>();
            factoryMappings = new Dictionary<Type, Func<ServiceProvider,object>>();
        }

        private void RegisterMapping(Type interfaceType, Type implementationType)
        {
            mappings[interfaceType] = implementationType;
        }

        public void AddTransient<TInterface, TImplementation>()
        {
            RegisterMapping(typeof(TInterface), typeof(TImplementation));
        }

        public void AddTransient<TInterface, TImplementation>(Func<ServiceProvider, object> factoryFunction)
        {
            RegisterMapping(typeof(TInterface), typeof(TImplementation));
            factoryMappings[typeof(TInterface)] = factoryFunction;
        }

        public void AddSingleton<TInterface, TImplementation>()
        {
            RegisterMapping(typeof(TInterface), typeof(TImplementation));
            singletonMappings[typeof(TInterface)] = typeof(TImplementation);
        }

        public void AddSingleton<TInterface, TImplementation>(Func<ServiceProvider, object> factoryFunction)
        {
            RegisterMapping(typeof(TInterface), typeof(TImplementation));
            singletonMappings[typeof(TInterface)] = typeof(TImplementation);
            factoryMappings[typeof(TInterface)] = factoryFunction;
        }

        public Type GetMapping(Type interfaceType)
        {
            if (!mappings.ContainsKey(interfaceType))
            {
                throw new ArgumentException($"No mapping found for {interfaceType.Name}");
            }

            return mappings[interfaceType]; 
        }

        public Func<ServiceProvider, object> GetFactory(Type interfaceType)
        {
            if (!factoryMappings.ContainsKey(interfaceType))
            {
                throw new ArgumentException($"No mapping found for {interfaceType.Name}");
            }

            return factoryMappings[interfaceType];
        }

        public bool HasFactory(Type type)
        {
            return factoryMappings.ContainsKey(type);
        }

        public bool IsSingleton(Type type)
        {
            return singletonMappings.ContainsKey(type);
        }

        public ServiceProvider BuildServiceProvider()
        {
            return new ServiceProvider(this);
        }
    }
}
