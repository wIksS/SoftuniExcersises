using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomDI
{
    internal class ServiceProvider : IServiceProvider
    {
        private ServiceCollection serviceCollection;
        public ServiceProvider(ServiceCollection serviceCollection)
        {
            this.serviceCollection = serviceCollection;
        }

        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        private object GetService(Type interfaceType)
        {
            if (serviceCollection.TransientMappingsWithFactories.ContainsKey(interfaceType))
            {
                return serviceCollection.TransientMappingsWithFactories[interfaceType](this);
            }

            Type implementationType = serviceCollection.TransientMappings[interfaceType];

            ConstructorInfo constructor = implementationType.GetConstructors()[0];
            ParameterInfo[] parameters = constructor.GetParameters();
            object[] parameterObjects = new object[parameters.Length];
            int index = 0;
            foreach (ParameterInfo parameter in parameters)
            {
                parameterObjects[index++] = GetService(parameter.ParameterType);
            }

            return Activator.CreateInstance(implementationType, parameterObjects);
        }
    }
}
