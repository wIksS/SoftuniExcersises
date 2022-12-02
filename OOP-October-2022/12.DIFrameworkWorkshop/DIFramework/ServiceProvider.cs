using DIFramework.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using IServiceProvider = DIFramework.Contracts.IServiceProvider;

namespace DIFramework
{
    public class ServiceProvider : Contracts.IServiceProvider
    {
        private IServiceCollection serviceCollection;
        public ServiceProvider(IServiceCollection serviceCollection)
        {
            this.serviceCollection = serviceCollection;
        }

        public object GetService(Type interfaceType)
        {
            Type serviceType = serviceCollection.GetMapping(interfaceType);

            MethodInfo method = serviceCollection.GetType().GetMethod(nameof(serviceCollection.GetFactory));

            method = method.MakeGenericMethod(serviceType);

            dynamic factory = method.Invoke(serviceCollection, new object[] { serviceType });

            if (factory!= null)
            {
                return factory(this);
            }

            ConstructorInfo[] constructors = serviceType.GetConstructors();

            //if (constructors.Length > 1)
            //{
            //    throw new ArgumentException($"Cannot inject type {serviceType.Name} with more than 1 constructors");
            //}

            ParameterInfo[] parameterInfos = constructors[0].GetParameters();
            object[] parameters  = new object[parameterInfos.Length];
            int index = 0;
            foreach (var parameter in parameterInfos)
            {
                parameters[index++] = GetService(parameter.ParameterType);
            }


            return Activator.CreateInstance(serviceType, parameters);
        }
    }
}
