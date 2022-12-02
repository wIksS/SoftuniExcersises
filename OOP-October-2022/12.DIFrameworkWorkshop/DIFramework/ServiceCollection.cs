using DIFramework.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using IServiceProvider = DIFramework.Contracts.IServiceProvider;

namespace DIFramework
{
    public class ServiceCollection : IServiceCollection
    {
        private Dictionary<Type, Type> mappings;
        private Dictionary<Type, object> typesWithFactories;

        public ServiceCollection()
        {
            mappings = new Dictionary<Type, Type>();

            typesWithFactories = new Dictionary<Type, object>();
        }

        public void AddTransient<TInterface, TImplementation>()
        {
            mappings.Add(typeof(TInterface), typeof(TImplementation));
        }

        public void AddTransient<TInterface, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory)
        {
            AddTransient<TInterface, TImplementation>();

            typesWithFactories.Add(typeof(TImplementation), implementationFactory);
        }

        public IServiceProvider BuildServiceProvider()
        {
            return new ServiceProvider(this);
        }

        public Type GetMapping(Type interfaceType)
        {
            if (!mappings.ContainsKey(interfaceType))
            {
                throw new ArgumentException($"Mapping for type {interfaceType.Name} has not been configured ");
            }

            return mappings[interfaceType];
        }

        public Func<IServiceProvider, TImplementation> GetFactory<TImplementation>(Type implementationType)
        {
            if (typesWithFactories.ContainsKey(implementationType))
            {
                return (Func<IServiceProvider, TImplementation>)typesWithFactories[implementationType];
            }

            return null;
        }

   }
}
